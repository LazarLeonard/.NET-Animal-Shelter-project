using Heaven.Models;
using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Heaven.Services
{
    public class ContactServices : Services<Contact>, IContactRepository
    {
        public ContactServices(AdapostContext repositoryContext) : base(repositoryContext)
        {
        }

        public bool ExistaAdapost(Contact contact)
        {

            return FFindByCondition(c => c.ContactId == contact.ContactId).Any();
        }
    }
}