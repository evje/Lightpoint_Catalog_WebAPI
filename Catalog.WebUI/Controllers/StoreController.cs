using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Catalog.Domain.Concrete;
using Catalog.Domain.Entities;
using System.Web;


namespace Catalog.WebUI.Controllers
{
    public class StoreController : ApiController
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        
        public IEnumerable<Store> GetAllStores()
        {
            var stores = _unitOfWork.StoreRepository.Get(includeProperties: "Goods").Select(x => 
            new Store() {Id = x.Id, Name = x.Name, Address = x.Address, Mode = x.Mode});
            //var stores = _unitOfWork.StoreRepository.Get();
            var result = stores as IList<Store> ?? stores.ToList();
            if (result.Count != 0)
            {
                return result;
            }
            else
            {
                var shortResult = new Store() { Id = 0, Name = "не найдено", Address = "не найдено", Mode = "не найдено" };
                result.Add(shortResult);
                return result;
            }
        }

        public ICollection<Good> GetGoodsByStoreId(Int32 storeId)
        {
            if (_unitOfWork.StoreRepository.GetByID((object)storeId) != null)
            {
                var goods = _unitOfWork.StoreRepository.GetByID((object)storeId).Goods.Select(x => new Good() { Id = x.Id, Name = x.Name, Description = x.Description });
                var result = goods as IList<Good> ?? goods.ToList();
                if (result.Count != 0)
                {
                    return result;
                }
                else
                {
                    var shortResult = new Good() { Id = 0, Name = "не найдено", Description = "не найдено" };
                    result.Add(shortResult);
                    return result;
                }
            }
            else
            {
                var result = new List<Good>();
                var shortResult = new Good() { Id = 0, Name = "не найдено", Description = "не найдено" };
                result.Add(shortResult);
                return result;
            }
            
        }

    }


}
