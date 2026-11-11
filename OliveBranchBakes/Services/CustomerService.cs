using System.Text.Json;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    // creates accounts and finds them again, saved in a json file
    public class CustomerService
    {
        private string folderPath;
        private string filePath;
        private List<AccountCustomer> accounts;

        public CustomerService()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            folderPath = Path.Combine(appData, "OliveBranchBakes");
            filePath = Path.Combine(folderPath, "accounts.json");
            accounts = LoadAccounts();
        }

        public AccountCustomer CreateAccount(string fullName, string phone, string email)
        {
            if (fullName.Trim() == "" || phone.Trim() == "" || email.Trim() == "")
            {
                throw new ArgumentException("Please fill in your name, phone and email.");
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new ArgumentException("Please enter a valid email.");
            }
            if (FindAccountByEmail(email) != null)
            {
                throw new ArgumentException("There is already an account with this email.");
            }

            AccountCustomer account = new AccountCustomer();
            account.CustomerId = GetNextId();
            account.FullName = fullName.Trim();
            account.Phone = phone.Trim();
            account.Email = email.Trim();
            accounts.Add(account);
            SaveAccounts();
            return account;
        }

        public AccountCustomer? FindAccountByEmail(string email)
        {
            foreach (AccountCustomer account in accounts)
            {
                if (account.Email.ToLower() == email.Trim().ToLower())
                {
                    return account;
                }
            }
            return null;
        }

        private int GetNextId()
        {
            int highest = 0;
            foreach (AccountCustomer account in accounts)
            {
                if (account.CustomerId > highest)
                {
                    highest = account.CustomerId;
                }
            }
            return highest + 1;
        }

        private void SaveAccounts()
        {
            try
            {
                Directory.CreateDirectory(folderPath);
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string json = JsonSerializer.Serialize(accounts, options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the account: " + ex.Message);
            }
        }

        private List<AccountCustomer> LoadAccounts()
        {
            if (!File.Exists(filePath))
            {
                return new List<AccountCustomer>();
            }

            try
            {
                string json = File.ReadAllText(filePath);
                List<AccountCustomer>? loaded = JsonSerializer.Deserialize<List<AccountCustomer>>(json);
                if (loaded == null)
                {
                    return new List<AccountCustomer>();
                }
                return loaded;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read the accounts file. " + ex.Message);
                return new List<AccountCustomer>();
            }
        }
    }
}
