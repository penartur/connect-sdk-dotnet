using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from a create payment call.
    /// </summary>
    public class DeclinedPaymentException : DeclinedTransactionException
    {
        /// <summary>
        /// Gets the result of creating a payment if available, otherwise <code>null</code>.
        /// </summary>
        public CreatePaymentResult CreatePaymentResult => _errors?.PaymentResult;

        public DeclinedPaymentException(System.Net.HttpStatusCode statusCode, string responseBody, PaymentErrorResponse errors)
            : base(BuildMessage(errors, responseBody), statusCode, responseBody, errors?.ErrorId, errors?.Errors)
        {
            _errors = errors;
        }

        readonly PaymentErrorResponse _errors;

        static string BuildMessage(PaymentErrorResponse errors, string responseBody)
        {
            Payment payment = errors?.PaymentResult?.Payment;
            if (payment != null)
            {
                return "declined payment '" + payment.Id + "' with status '" + payment.Status + "'";
            }
            return "the GlobalCollect platform returned a declined refund response";
        }
    }
}

