/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Payout;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Payouts
{
    /// <summary>
    /// Payouts client. Thread-safe.
    /// </summary>
    public class PayoutsClient : ApiResource
    {
        public PayoutsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/payouts
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__payouts_post">Create payout</a>
        /// </summary>
        /// <param name="body">CreatePayoutRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>PayoutResponse</returns>
        /// <exception cref="DeclinedPayoutException">if the GlobalCollect platform declined / rejected the payout. The payout result will be available from the exception.</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PayoutResponse> Create(CreatePayoutRequest body, CallContext context = null)
        {
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/payouts", null);
            try
            {
                return await _communicator.Post<PayoutResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        errorObject = _communicator.Marshaller.Unmarshal<PayoutErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/payouts/{payoutId}
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__payouts__payoutId__get">Get payout</a>
        /// </summary>
        /// <param name="payoutId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>PayoutResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PayoutResponse> Get(string payoutId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("payoutId", payoutId);
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/payouts/{payoutId}", pathContext);
            try
            {
                return await _communicator.Get<PayoutResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/payouts/{payoutId}/approve
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__payouts__payoutId__approve_post">Approve payout</a>
        /// </summary>
        /// <param name="payoutId">string</param>
        /// <param name="body">ApprovePayoutRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>PayoutResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PayoutResponse> Approve(string payoutId, ApprovePayoutRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("payoutId", payoutId);
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/payouts/{payoutId}/approve", pathContext);
            try
            {
                return await _communicator.Post<PayoutResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.PaymentRequired:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/payouts/{payoutId}/cancel
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__payouts__payoutId__cancel_post">Cancel payout</a>
        /// </summary>
        /// <param name="payoutId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>void</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task Cancel(string payoutId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("payoutId", payoutId);
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/payouts/{payoutId}/cancel", pathContext);
            try
            {
                await _communicator.Post<object>(
                        uri,
                        ClientHeaders,
                        null,
                        null,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.PaymentRequired:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/payouts/{payoutId}/cancelapproval
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__payouts__payoutId__cancelapproval_post">Undo approve payout</a>
        /// </summary>
        /// <param name="payoutId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>void</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task Cancelapproval(string payoutId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("payoutId", payoutId);
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/payouts/{payoutId}/cancelapproval", pathContext);
            try
            {
                await _communicator.Post<object>(
                        uri,
                        ClientHeaders,
                        null,
                        null,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.MethodNotAllowed:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }
    }
}
