// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Service.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The X509 device enrollment record - with Signing Certificate.
    /// </summary>
    public partial class X509CertificateEnrollmentGroupResponse : EnrollmentGroupResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// X509CertificateEnrollmentGroupResponse class.
        /// </summary>
        public X509CertificateEnrollmentGroupResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// X509CertificateEnrollmentGroupResponse class.
        /// </summary>
        /// <param name="enrollmentGroupId">Enrollment Group ID.</param>
        /// <param name="attestation">X509 Primary and secondary
        /// certificates</param>
        /// <param name="iotHubHostName">The Iot Hub host name.</param>
        /// <param name="initialTwin">Initial device twin.</param>
        /// <param name="etag">The entity tag associated with the
        /// resource.</param>
        /// <param name="provisioningStatus">The provisioning status. Possible
        /// values include: 'enabled', 'disabled'</param>
        /// <param name="reprovisionPolicy">The behavior when a device is
        /// re-provisioned to an IoT hub.</param>
        /// <param name="createdDateTimeUtc">The DateTime this resource was
        /// created.</param>
        /// <param name="lastUpdatedDateTimeUtc">The DateTime this resource was
        /// last updated.</param>
        /// <param name="allocationPolicy">The allocation policy of this
        /// resource. This policy overrides the tenant level allocation policy
        /// for this individual enrollment or enrollment group. Possible values
        /// include 'hashed': Linked IoT hubs are equally likely to have
        /// devices provisioned to them, 'geoLatency':  Devices are provisioned
        /// to an IoT hub with the lowest latency to the device.If multiple
        /// linked IoT hubs would provide the same lowest latency, the
        /// provisioning service hashes devices across those hubs, 'static' :
        /// Specification of the desired IoT hub in the enrollment list takes
        /// priority over the service-level allocation policy, 'custom':
        /// Devices are provisioned to an IoT hub based on your own custom
        /// logic. The provisioning service passes information about the device
        /// to the logic, and the logic returns the desired IoT hub as well as
        /// the desired initial configuration. We recommend using Azure
        /// Functions to host your logic. Possible values include: 'hashed',
        /// 'geoLatency', 'static', 'custom'</param>
        /// <param name="iotHubs">The list of names of IoT hubs the device(s)
        /// in this resource can be allocated to. Must be a subset of tenant
        /// level list of IoT hubs.</param>
        /// <param name="customAllocationDefinition">Custom allocation
        /// definition.</param>
        public X509CertificateEnrollmentGroupResponse(string enrollmentGroupId, X509CertificatesResponse attestation, string iotHubHostName = default(string), InitialTwin initialTwin = default(InitialTwin), string etag = default(string), string provisioningStatus = default(string), ReprovisionPolicy reprovisionPolicy = default(ReprovisionPolicy), System.DateTime? createdDateTimeUtc = default(System.DateTime?), System.DateTime? lastUpdatedDateTimeUtc = default(System.DateTime?), string allocationPolicy = default(string), IList<string> iotHubs = default(IList<string>), CustomAllocationDefinition customAllocationDefinition = default(CustomAllocationDefinition))
            : base(enrollmentGroupId, iotHubHostName, initialTwin, etag, provisioningStatus, reprovisionPolicy, createdDateTimeUtc, lastUpdatedDateTimeUtc, allocationPolicy, iotHubs, customAllocationDefinition)
        {
            Attestation = attestation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets X509 Primary and secondary certificates
        /// </summary>
        [JsonProperty(PropertyName = "attestation")]
        public X509CertificatesResponse Attestation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Attestation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Attestation");
            }
            if (Attestation != null)
            {
                Attestation.Validate();
            }
        }
    }
}
