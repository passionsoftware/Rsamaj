using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.DataModel;
using RS.DataAccessLayer.entitydata;


namespace RS.DataAccessLayer
{
    public  class ContactDetailDL
    {
        public int InsertContact(ContactModel obj)
        {
            int result = 0;

            using (RSEntities objEnt = new RSEntities())
            {
                RS_ContactUs oData = new RS_ContactUs();
                oData.Name = obj.Name;
                oData.PhoneNumber = obj.PhoneNumber;
                oData.EmailId = obj.EmailId;
                oData.Body = obj.Body;
                oData.Subject = obj.Subject;
                oData.CreatedOn = DateTime.Now;
                oData.Location = obj.Location;
                oData.IpAddress = obj.IpAddress;

                objEnt.RS_ContactUs.Add(oData);

                result = objEnt.SaveChanges();
            }

            return result;
        }

        public int UpdateContact(ContactModel objRathoreDetail)
        {
            int result = 0;

            return result;
        }

        public int DeleteContact(int Id)
        {
            int result = 0;

            using (RSEntities obj = new RSEntities())
            {
                var oSelect = obj.RS_ContactUs.First(i => i.ContactusId == Id);
                obj.RS_ContactUs.Remove(oSelect);

                result =  obj.SaveChanges();
            }

            return result;
        }

        public List<ContactModel> GetAllContactDetail()
        {
            List<ContactModel> result = new List<ContactModel>();

            using (RSEntities obj = new RSEntities())
            {
                result = (from odata in obj.RS_ContactUs
                        select new ContactModel
                        {
                            Name = odata.Name,
                            PhoneNumber = odata.PhoneNumber,
                            EmailId = odata.EmailId,
                            Subject = odata.Subject,
                            Body = odata.Body,
                            Location = odata.Location,
                            IpAddress = odata.IpAddress
                        }).ToList();
            }

            return result;
        }

        public ContactModel GetContactId(int id)
        {
            ContactModel result = new ContactModel();

            using (RSEntities obj = new RSEntities())
            {
                result = (from odata in obj.RS_ContactUs
                           where odata.ContactusId == id
                           select new ContactModel
                           {
                               Name = odata.Name,
                               PhoneNumber = odata.PhoneNumber,
                               EmailId = odata.EmailId,
                               Subject = odata.Subject,
                               Body = odata.Body,
                               Location = odata.Location,
                               IpAddress = odata.IpAddress
                           }).First();
            }

            return result;
        }
    }
}
