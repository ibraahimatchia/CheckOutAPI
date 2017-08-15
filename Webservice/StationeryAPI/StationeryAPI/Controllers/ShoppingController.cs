using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingDataAccess;

namespace StationeryAPI.Controllers
{
    public class ShoppingController : ApiController
    {
        public IEnumerable<Shopping> Get()
        {
            using (CheckOutEntities entities = new CheckOutEntities())
            {
                return entities.Shoppings.ToList();
            }
        }

        [HttpGet()]
        [Route("api/Shopping/{itemName}")]
        public HttpResponseMessage Get(string itemName)
        {
            using (CheckOutEntities entities = new CheckOutEntities())
            {
                var entity = entities.Shoppings.FirstOrDefault(s => s.ItemName == itemName);

                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item with id = " + itemName.ToString() + " not found");
                }
            }
        }

        public HttpResponseMessage Post([FromBody] Shopping item)
        {
            try
            {
                using (CheckOutEntities entities = new CheckOutEntities())
                {
                    entities.Shoppings.Add(item);
                    entities.SaveChanges();

                    var msg = Request.CreateResponse(HttpStatusCode.Created, item);

                    msg.Headers.Location = new Uri(Request.RequestUri + item.ID.ToString());

                    return msg;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpDelete()]
        [Route("api/Shopping/{itemName}")]
        public HttpResponseMessage Delete(string itemName)
        {
            try
            {
                using (CheckOutEntities entities = new CheckOutEntities())
                {
                    var entity = entities.Shoppings.FirstOrDefault(s => s.ItemName == itemName);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item with id = " + itemName.ToString() + " not found");
                    }
                    else
                    {
                        entities.Shoppings.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        public HttpResponseMessage Put(int id, [FromBody]Shopping item)
        {
            try
            {
                using (CheckOutEntities entities = new CheckOutEntities())
                {
                    var entity = entities.Shoppings.FirstOrDefault(s => s.ID == id);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item with id = " + id.ToString() + " not found");
                    }
                    else
                    {
                        entity.ItemName = item.ItemName;
                        entity.Quantity = item.Quantity;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPut()]
        [Route("api/Shopping/{itemName}")]
        public HttpResponseMessage Put(string itemName, [FromBody]Shopping item)
        {
            try
            {
                using (CheckOutEntities entities = new CheckOutEntities())
                {
                    var entity = entities.Shoppings.FirstOrDefault(s => s.ItemName == itemName);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item with id = " + itemName.ToString() + " not found");
                    }
                    else
                    {
                        entity.ItemName = item.ItemName;
                        entity.Quantity = item.Quantity;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
