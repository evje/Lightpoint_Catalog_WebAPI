﻿USE master;
CREATE DATABASE CatalogDbWebAPI
ON (NAME=CatalogDb_dat,
FILENAME = 'E:\test\Lightpoint\WebAPI\Catalog.WebUI\App_Data\CatalogDb.mdf',
SIZE = 3,
MAXSIZE = 100,
FILEGROWTH = 1)
LOG ON
(NAME=CatalogDb_log,
FILENAME = 'E:\test\Lightpoint\WebAPI\Catalog.WebUI\App_Data\CatalogDb.ldf',
SIZE = 1,
MAXSIZE = 100,
FILEGROWTH = 1);