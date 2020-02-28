using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UserInterfaceApp
{
    class ContactService
    {
        public ContactService()
        {
           
            Contacts = new ObservableCollection<Contact>();
        }
        public ObservableCollection<Contact> Contacts { get; set; }

        public async Task<ObservableCollection<Contact>> GetEmployeesAsync(string query)
        {
            //Thread.Sleep(2000);

            if (query != string.Empty)
            {
                Contacts.Clear();
             
                List<Contact> llstContact = Contacts.Where(emp => (emp.LastName.ToLower().Contains(query.ToLower())
                                                                    || emp.FirstName.ToLower().Contains(query.ToLower()))).ToList();

                Contacts.Clear();
                foreach (Contact contact in llstContact)
                {
                    Contacts.Add(contact);
                }

            }
            
            return await Task.FromResult(Contacts);
        }

        public async Task<bool> AddContactAsync(Contact contact)
        {
            Contacts.Add(contact);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateContactAsync(Contact contact)
        {
            Contact contactToEdit = Contacts.Where(emp => emp.Phone == contact.Phone).FirstOrDefault();

            int newIdex = Contacts.IndexOf(contactToEdit);
            Contacts.Remove(contactToEdit);

            Contacts.Add(contact);
            int oldIndex = Contacts.IndexOf(contact);

            Contacts.Move(oldIndex, newIdex);

            return await Task.FromResult(true);
        }
    }
}
