/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CustomerTokenWithContactDetails">CustomerTokenWithContactDetails</a>
    /// </summary>
    public class CustomerTokenWithContactDetails : CustomerToken
    {
        public ContactDetailsToken ContactDetails { get; set; } = null;
    }
}
