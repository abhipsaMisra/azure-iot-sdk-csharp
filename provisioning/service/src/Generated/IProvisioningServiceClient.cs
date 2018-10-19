// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Service
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// API for service operations with the Azure IoT Hub Device Provisioning
    /// Service
    /// </summary>
    public partial interface IProvisioningServiceClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// The API version to use for the request. Supported versions include:
        /// 2018-09-01-preview
        /// </summary>
        string ApiVersion { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Get a device enrollment record.
        /// </summary>
        /// <param name='id'>
        /// Registration ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IndividualEnrollment>> GetIndividualEnrollmentWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a device enrollment record.
        /// </summary>
        /// <param name='id'>
        /// Registration ID.
        /// </param>
        /// <param name='ifMatch'>
        /// The ETag of the enrollment record.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteIndividualEnrollmentWithHttpMessagesAsync(string id, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a device enrollment group.
        /// </summary>
        /// <param name='id'>
        /// Enrollment group ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<EnrollmentGroup>> GetEnrollmentGroupWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a device enrollment group.
        /// </summary>
        /// <param name='id'>
        /// Enrollment group ID.
        /// </param>
        /// <param name='ifMatch'>
        /// The ETag of the enrollment group record.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteEnrollmentGroupWithHttpMessagesAsync(string id, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the device registration state.
        /// </summary>
        /// <param name='id'>
        /// Registration ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<DeviceRegistrationState>> GetDeviceRegistrationStateWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the device registration
        /// </summary>
        /// <param name='id'>
        /// Registration ID.
        /// </param>
        /// <param name='ifMatch'>
        /// The ETag of the registration status record.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteDeviceRegistrationStateWithHttpMessagesAsync(string id, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Device enrollment operation.
        /// </summary>
        /// <param name='enrollmentOperation'>
        /// Individual enrollment operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<EnrollmentOperationResult>> RunEnrollmentOperationWithHttpMessagesAsync(EnrollmentOperation enrollmentOperation, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query the device enrollment records.
        /// </summary>
        /// <param name='querySpecification'>
        /// The query specification.
        /// </param>
        /// <param name='xMsMaxItemCount'>
        /// pageSize
        /// </param>
        /// <param name='xMsContinuation'>
        /// continuation token
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<IndividualEnrollment>,QueryIndividualEnrollmentsHeaders>> QueryIndividualEnrollmentsWithHttpMessagesAsync(QuerySpecification querySpecification, int? xMsMaxItemCount = default(int?), string xMsContinuation = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get the attestation mechanism in the device enrollment record
        /// </summary>
        /// <param name='id'>
        /// Registration ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AttestationMechanism>> GetIndividualEnrollmentAttestationMechanismWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query the device enrollment groups.
        /// </summary>
        /// <param name='querySpecification'>
        /// The query specification.
        /// </param>
        /// <param name='xMsMaxItemCount'>
        /// pageSize
        /// </param>
        /// <param name='xMsContinuation'>
        /// continuation token
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<EnrollmentGroup>,QueryEnrollmentGroupsHeaders>> QueryEnrollmentGroupsWithHttpMessagesAsync(QuerySpecification querySpecification, int? xMsMaxItemCount = default(int?), string xMsContinuation = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get the attestation mechanism in the device enrollment group record
        /// </summary>
        /// <param name='id'>
        /// Enrollment group ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AttestationMechanism>> GetEnrollmentGroupAttestationMechanismWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the registration state of devices in this enrollmentGroup.
        /// </summary>
        /// <param name='id'>
        /// Enrollment group ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<DeviceRegistrationState>>> QueryDeviceRegistrationStatesWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
