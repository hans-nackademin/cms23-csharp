using CimoApp.Mvvm.Models;

namespace CimoApp.Services
{
    public class ContactService
    {
        private static List<ContactModel> contacts = new List<ContactModel>();
        public static event Action ContactsUpdated;


        public static void AddToList(ContactModel contact)
        {
            contacts.Add(contact);
            ContactsUpdated.Invoke();
        }

        public static List<ContactModel> GetContacts()
        {
            return contacts;
        }
    }
}
