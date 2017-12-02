using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;



namespace La11_A
{


    class Program
    {
        static void Main(string[] args)
        {
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //  var products = AWEntities.Product;
            //IQueryable<string> productNames = from p in products select p.Name;
            //Console.WriteLine("Productos :");
            //foreach(var productName in productNames)
            //{
            //  Console.WriteLine(productName);

            //                }
            //            Console.ReadKey();
            //          }

            // using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //  var products = AWEntities.Product;
            //IQueryable<string> productNames = products.Select(p => p.Name);

            //Console.WriteLine("Productos:");
            // foreach(var productName in productNames)
            //{
            //  Console.WriteLine(productName);
            //}
            //Console.ReadKey();
            //}

            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //var products = AWEntities.Product;

            //IQueryable<Product> productsQuery = from p in products select p;
            //IQueryable<Product> largeProducts = productsQuery.Where (p => p.Size == "L");

            //Console.WriteLine("Productos de tamano :");
            //foreach (var prod in productsQuery)
            //{
            //  Console.WriteLine(prod.Name);
            //}

            //  Console.ReadKey();

            //}

            //using (AdventureWorksEntities  context = new AdventureWorksEntities())
            //{
            //IQueryable<Product> productsQuery = from product in context.Product select product;

            //Console.WriteLine("Productos:");
            //foreach (var prod in productsQuery)
            //{
            //  Console.WriteLine(prod.Name);
            //}

            //  Console.ReadKey();
            //}


            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //     var query = from product in context.Product
            //  select new
            //    {
            //          ProductId = product.ProductID,
            //            ProductName = product.Name
            //          };
            //Console.WriteLine(" informacion de productos:");
            //foreach(var productInfo in query)
            //{
            // Console.WriteLine("Product Id: {0} Product  name: {1}",
            //   productInfo.ProductId, productInfo.ProductName);
            // }
            //   Console.ReadKey();
            // }

            //decimal totalDue = 500.00M;
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //var contacts = context.Contact;
            //var orders = context.SalesOrderHeader;

            //var query = from contact in contacts
            //from order in orders
            //where contact.ContactID == order.Contact.ContactID && order.TotalDue < totalDue
            //select new
            // {
            //    contactID = contact.ContactID,
            //      LastName = contact.LastName,
            //        FirstName = contact.FirstName,
            //          OrderID = order.SalesOrderID,
            //            total = order.TotalDue
            //          };
            //foreach (var smallOrder in query)
            //{
            // Console.WriteLine("Contact ID: {0} \t Name: {1}, {2} \t Order ID: {3}" + "/tTotal Due:${4}",
            //       smallOrder.contactID, smallOrder.LastName, smallOrder.FirstName, smallOrder.OrderID, smallOrder.total);
            // }
            //   Console.ReadKey();

            // }

            /* using (AdventureWorksEntities context = new AdventureWorksEntities())
             {
                 var contacts = context.Contact;
                 var orders = context.SalesOrderHeader;

                 var query = from contact in contacts
                             from order in orders
                             where contact.ContactID == order.Contact.ContactID && order.OrderDate >= new DateTime(2002, 10, 1)
                             select new
                             {
                                 contactID = contact.ContactID,
                                 LastName = contact.LastName,
                                 FirstName = contact.FirstName,
                                 OrderID = order.SalesOrderID,
                                 OrderDate = order.OrderDate

                             };

                 foreach (var order in query)
                 {
                     Console.WriteLine("Contact ID: {0} \t Order ID : {3}, \t Order date: {4}",
                         order.contactID, order.LastName, order.FirstName,
                         order.OrderID, order.OrderDate);
                 }
                 Console.ReadKey();
             }*/

            /* int orderQtymin = 2;
             int orderQtymax = 6;

             using (AdventureWorksEntities context = new AdventureWorksEntities())
             {
                 var query = from order in context.SalesOrderDetail
                             where order.OrderQty > orderQtymin
                             && order.OrderQty < orderQtymax
                             select new
                             {
                                 SalesOrderID = order.SalesOrderID,
                                 OrderQty = order.OrderQty
                             };
                 foreach (var order in query)
                 {
                     Console.WriteLine("Order ID: {0} Order quantity:{1}",
                         order.SalesOrderID, order.OrderQty);
                 }
                 Console.ReadKey();
             }*/

            /* String color = "red";
             using (AdventureWorksEntities context = new AdventureWorksEntities())
             {
                 var query = from product in context.Product
                             where product.Color == color
                             select new
                             {
                                 Name = product.Name,
                                 ProductNumber = product.ProductNumber,
                                 ListPrice = product.ListPrice
                             };
                 foreach ( var product in query)
                 {
                     Console.WriteLine("Name:{0}", product.Name);
                     Console.WriteLine("Product Number:{0}", product.ProductNumber);
                     Console.WriteLine("List price:{0}", product.ListPrice);
                     Console.WriteLine("");
                 }
                 Console.ReadKey();
             }
             */

            /*using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                int?[] productModelIds = { 19, 26, 118 };
                var products = from p in AWEntities.Product
                               where productModelIds.Contains(p.ProductModelID)
                               select p;
                foreach (var product in products)
                {
                    Console.WriteLine("{0}:{1}",
                        product.ProductModelID, product.ProductID);
                }
                Console.ReadKey();
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Contact> SortedNames = from n in context.Contact
                                                  orderby n.LastName
                                                  select n;
                Console.WriteLine("Lista ordenada por Apellidos");
                foreach(Contact n in SortedNames)
                {
                    Console.WriteLine(n.LastName);
                }
                Console.ReadKey();
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Decimal> SortedPrices = from p in context.Product
                                                  orderby p.ListPrice descending
                                                  select p.ListPrice;
                Console.WriteLine("Lista de los precios desde el mas alto al mas bajo");
                foreach (Decimal price in SortedPrices)
                {
                    Console.WriteLine(price);
                }
                Console.ReadKey();
            }*/


            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Contact> SortedContacs = from contact in context.Contact
                                                  orderby contact.LastName, contact.FirstName
                                                  select contact;
                Console.WriteLine("Contactos ordenados por Apellidos y luego por nombre");
                foreach (Contact SortedContact in SortedContacs)
                {
                    Console.WriteLine(SortedContact.LastName + "," + SortedContact.FirstName);
                }
                Console.ReadKey();
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var products = context.Product;
                var query = from product in products
                            group product by product.Style into g
                            select new
                            {
                                Style = g.Key,
                                AverageListPrice = g.Average(product => product.ListPrice)
                            };
                foreach(var product in query)
                {
                    Console.WriteLine("Estilo: {0} Precio Promedio: {1}",
                        product.Style, product.AverageListPrice);
                }
                Console.ReadKey();
            }*/

            /* using (AdventureWorksEntities context = new AdventureWorksEntities())
             {
                 var products = context.Product;
                 var query = from product in products
                             group product by product.Color into g
                             select new
                             {
                                 Color = g.Key,
                                 tProductCount = g.Count()
                             };
                 foreach (var product in query)
                 {
                     Console.WriteLine("Color: {0} \t Cantidad: {1}",
                         product.Color, product.tProductCount);
                 }
                 Console.ReadKey();
             }*/

            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var orders = context.SalesOrderHeader;
                var query = from order in orders
                            group order by order.Contact.ContactID into g
                            select new
                            {
                                Category = g.Key,
                                maxTotalDue = g.Max(order => order.TotalDue)
                            };
                foreach (var order in query)
                {
                    Console.WriteLine("ContactID = {0} \t TotalDue Maximo = {1}",
                        order.Category, order.maxTotalDue);
                }
                Console.ReadKey();
            }

        }
    }
}
