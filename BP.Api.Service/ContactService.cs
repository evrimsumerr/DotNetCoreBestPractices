using AutoMapper;
using BP.Api.Data.Models;
using BP.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BP.Api.Service
{
    public class ContactService : IContactService
    {
        private readonly IMapper mapper;

        public ContactService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public ContactDVO GetContactById(int id)
        {
            //DB get data
            Contact dbContact = getFakeContact();

            ContactDVO result = mapper.Map<ContactDVO>(dbContact);

            return result;
        }

        private Contact getFakeContact()
        {
            return new Contact
            {
                Id = 1,
                FirstName = "Evrim",
                LastName = "Sümer"
            };
        }
    }
}
