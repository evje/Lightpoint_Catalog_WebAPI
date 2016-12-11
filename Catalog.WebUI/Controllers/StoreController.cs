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
        private UnitOfWork unitOfWork = new UnitOfWork();

        public List<Store> GetAllStores()
        {
            List<Store> stores = unitOfWork.StoreRepository.Get(includeProperties: "Goods").ToList();

            return stores;
        }

        public List<Good> GetGoodsByStoreId(Int32 storeId)
        {
            var goods = unitOfWork.GoodRepository.Get().Where(x => (x.StoreId == storeId)).ToList();

            return goods;
        }

    }


}
