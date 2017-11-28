using RS.DataAccessLayer;
using RS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BusinessLogicLayer
{
    public class ContactDetailBL
    {
        ContactDetailDL _contactDetailDL;

        public ContactDetailBL()
        {
            _contactDetailDL = new ContactDetailDL();
        }

        public int InsertContact(ContactModel obj)
        {
            int result = 0;
            result = _contactDetailDL.InsertContact(obj);
            return result;
        }

        public int UpdateContact(ContactModel obj)
        {
            int result = 0;
            result = _contactDetailDL.UpdateContact(obj);
            return result;
        }

        public int DeleteContact(int id)
        {
            int result = 0;
            result = _contactDetailDL.DeleteContact(id);
            return result;
        }

        public List<ContactModel> GetAllContactDetail()
        {
            List<ContactModel> result = new List<ContactModel>();
            result = _contactDetailDL.GetAllContactDetail();
            return result;
        }

        public ContactModel GetContactId(int id)
        {
            ContactModel result = new ContactModel();
            result = _contactDetailDL.GetContactId(id);
            return result;
        }
    }
}
