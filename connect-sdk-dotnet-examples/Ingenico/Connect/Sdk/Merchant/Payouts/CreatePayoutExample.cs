/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using Ingenico.Connect.Sdk.Domain.Payout;
using Ingenico.Connect.Sdk.Domain.Payout.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Payouts
{
    public class CreatePayoutExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 2345L;
                amountOfMoney.CurrencyCode = "EUR";

                BankAccountIban bankAccountIban = new BankAccountIban();
                bankAccountIban.AccountHolderName = "Wile E. Coyote";
                bankAccountIban.Iban = "IT60X0542811101000000123456";

                Address address = new Address();
                address.City = "Burbank";
                address.CountryCode = "US";
                address.HouseNumber = "411";
                address.State = "California";
                address.Street = "N Hollywood Way";
                address.Zip = "91505";

                CompanyInformation companyInformation = new CompanyInformation();
                companyInformation.Name = "Acme Labs";

                ContactDetailsBase contactDetails = new ContactDetailsBase();
                contactDetails.EmailAddress = "wile.e.coyote@acmelabs.com";

                PersonalName name = new PersonalName();
                name.FirstName = "Wile";
                name.Surname = "Coyote";
                name.SurnamePrefix = "E.";
                name.Title = "Mr.";

                PayoutCustomer customer = new PayoutCustomer();
                customer.Address = address;
                customer.CompanyInformation = companyInformation;
                customer.ContactDetails = contactDetails;
                customer.Name = name;

                PayoutReferences references = new PayoutReferences();
                references.MerchantReference = "AcmeOrder001";

                CreatePayoutRequest body = new CreatePayoutRequest();
                body.AmountOfMoney = amountOfMoney;
                body.BankAccountIban = bankAccountIban;
                body.Customer = customer;
                body.PayoutDate = "20150102";
                body.PayoutText = "Payout Acme";
                body.References = references;
                body.SwiftCode = "swift";

                try
                {
                    PayoutResponse response = await client.Merchant("merchantId").Payouts().Create(body);
                }
                catch (DeclinedPayoutException e)
                {
                    HandleDeclinedPayout(e.PayoutResult);
                }
                catch (ApiException e)
                {
                    HandleApiErrors(e.Errors);
                }
            }
#pragma warning restore 0168
        }

        private Client GetClient()
        {
            string apiKeyId = "someKey";
            string secretApiKey = "someSecret";

            CommunicatorConfiguration configuration = Factory.CreateConfiguration(apiKeyId, secretApiKey);
            return Factory.CreateClient(configuration);
        }

        private void HandleDeclinedPayout(PayoutResult payoutResult)
        {
            // handle the result here
        }

        private void HandleApiErrors(IList<APIError> errors)
        {
            // handle the errors here
        }
    }
}
