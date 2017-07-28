using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using ASB_Integration.Mocking;
using ASB_Integration.Models;

namespace ASB_Integration.Controllers
{
    public class MembersController : ApiController
    {
        private MockMemberRepository MemberRepository;

        public MembersController()
        {
            MemberRepository = new MockMemberRepository(1000);
        }

        // GET api/members
        [SwaggerOperation("GetAll")]
        public IEnumerable<Member> Get()
        {
            return MemberRepository.GetAll();
        }

        // GET api/members/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Member Get(int id)
        {
            var member = MemberRepository.Get(id);

            if (member == null)
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "Member does not exist."));

            return member;
        }

        // POST api/members
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
            //TODO: Add Code
        }

        // PUT api/members/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
            //TODO: Add Code
        }

        // DELETE api/members/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
            //TODO: Add Code
        }
    }
}
