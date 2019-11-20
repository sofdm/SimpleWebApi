using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class OnePieceController : ApiController
    {

        List<Character> character = new List<Character>();
        public OnePieceController()
        {
            character.Add(new Character { Name = "Luffy", Position = "Captain", Id = 1 });
            character.Add(new Character { Name = "Zoro", Position = "SwordMan", Id = 2 });
            character.Add(new Character { Name = "Sanji", Position = "KickMan", Id = 3 });
        }
        // GET: api/OnePiece
        public List<Character> Get()
        {
            return character;
        }

        // GET: api/OnePiece/5
        public Character Get(int id)
        {
            return character.Where(x=>x.Id==id).FirstOrDefault();
        }

        // POST: api/OnePiece
        public void Post([FromBody]Character value)
        {

            character.Add(value);
        }

        // PUT: api/OnePiece/5
        public void Put(int id, [FromBody] Character value)
        {
            //character.Where(x => x.Id == id).FirstOrDefault() = value;
        }

        /// <summary>
        /// delete selected character
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/OnePiece/5
        public void Delete(int id)
        {
            character.Remove(character.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
