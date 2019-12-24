using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Data
{
    public class CapaData
    {
        DataProductsEntities BD = new DataProductsEntities();

        public void InsertProduct(Producto p)
        {
            BD.Products.Add(
                new Products()
                {
                    IdType = p.idType,
                    IdColor = p.idColor,
                    IdBrand = p.idBrand,
                    IdProvider = p.idProvider,
                    IdCatalog = p.idCatalog,
                    Title = p.title,
                    Nombre = p.nombre,
                    Description = p.description,
                    Observations = p.observations,
                    PriceDistributor = p.priceDistributor,
                    PriceClient = p.priceClient,
                    PriceMember = p.priceMember,
                    IsEnabled = p.isEnabled,
                    DateUpdate = p.dateUpdate
                });
            BD.SaveChanges();
        }
        public void DeletedProduct(int id)
        {
            BD.Products.Remove(
                BD.Products.FirstOrDefault(p => p.Id == id)
                );
            BD.SaveChanges();
        }
        public void UpdateProduct(Producto p)
        {
            if (p.Id.HasValue)
            {
                var producto = (from o in BD.Products where o.Id == p.Id select o).FirstOrDefault();
                producto.IdBrand = p.idBrand;
                producto.IdCatalog = p.idCatalog;
                producto.IdProvider = p.idProvider;
                producto.IdType = p.idType;
                producto.Title = p.title;
                producto.Nombre = p.nombre;
                producto.PriceDistributor = p.priceDistributor;
                producto.PriceClient = p.priceClient;
                producto.PriceMember = p.priceMember;
                producto.Observations = p.observations;
                producto.Description = p.description;
                producto.IsEnabled = p.isEnabled;
                producto.DateUpdate = p.dateUpdate;
                BD.SaveChanges();
            }
            else
            {
                InsertProduct(p);
            }
        }
    }
}
