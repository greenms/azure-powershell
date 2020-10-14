//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DiskConfig", SupportsShouldProcess = true)]
    [OutputType(typeof(PSDisk))]
    public partial class NewAzureRmDiskConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [Alias("AccountType")]
        [PSArgumentCompleter("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS")]
        public string SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("P1", "P2", "P3", "P4", "P5", "P6", "P10", "P15", "P20", "P30",
            "P40", "P50", "P60", "P70", "P80")]
        public string Tier { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int LogicalSectorSize { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemTypes? OsType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public int DiskSizeGB { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Compute/disks")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string[] Zone { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("V1", "V2")]
        public string HyperVGeneration { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public long DiskIOPSReadWrite { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public long DiskMBpsReadWrite { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public long DiskIOPSReadOnly { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public long DiskMBpsReadOnly { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MaxSharesCount { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string CreateOption { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string StorageAccountId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public ImageDiskReference ImageReference { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public ImageDiskReference GalleryImageReference { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string SourceUri { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string SourceResourceId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public long UploadSizeInBytes { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public bool? EncryptionSettingsEnabled { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string DiskEncryptionSetId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("EncryptionAtRestWithPlatformKey", "EncryptionAtRestWithCustomerKey")]
        public string EncryptionType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string DiskAccessId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("AllowAll", "AllowPrivate", "DenyAll")]
        public string NetworkAccessPolicy { get; set; }

        [Parameter(
    Mandatory = false,
    ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("P1", "P2", "P3", "P4", "P5", "P6", "P10", "P15", "P20", "P30",
    "P40", "P50", "P60", "P70", "P80")]
        public string Tier { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int LogicalSectorSize { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("Disk", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // Sku
            DiskSku vSku = null;

            // CreationData
            CreationData vCreationData = null;

            // EncryptionSettingsCollection
            EncryptionSettingsCollection vEncryptionSettingsCollection = null;

            // Encryption
            Encryption vEncryption = null;

            if (this.IsParameterBound(c => c.SkuName))
            {
                if (vSku == null)
                {
                    vSku = new DiskSku();
                }
                vSku.Name = this.SkuName;
            }

            if (this.IsParameterBound(c => c.CreateOption))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.CreateOption = this.CreateOption;
            }

            if (this.IsParameterBound(c => c.StorageAccountId))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.StorageAccountId = this.StorageAccountId;
            }

            if (this.IsParameterBound(c => c.ImageReference))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.ImageReference = this.ImageReference;
            }

            if (this.IsParameterBound(c => c.GalleryImageReference))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.GalleryImageReference = this.GalleryImageReference;
            }

            if (this.IsParameterBound(c => c.SourceUri))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.SourceUri = this.SourceUri;
            }

            if (this.IsParameterBound(c => c.SourceResourceId))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.SourceResourceId = this.SourceResourceId;
            }

            if (this.IsParameterBound(c => c.UploadSizeInBytes))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.UploadSizeBytes = this.UploadSizeInBytes;
            }

            if (this.IsParameterBound(c => c.LogicalSectorSize))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.LogicalSectorSize = this.LogicalSectorSize;
            }

            if (this.IsParameterBound(c => c.EncryptionSettingsEnabled))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }
                vEncryptionSettingsCollection.Enabled = (bool) this.EncryptionSettingsEnabled;
            }

            if (this.IsParameterBound(c => c.DiskEncryptionKey))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings == null)
                {
                    vEncryptionSettingsCollection.EncryptionSettings = new List<EncryptionSettingsElement>();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings.Count == 0)
                {
                    vEncryptionSettingsCollection.EncryptionSettings.Add(new EncryptionSettingsElement());
                }

                vEncryptionSettingsCollection.EncryptionSettings[0].DiskEncryptionKey = this.DiskEncryptionKey;
            }

            if (this.IsParameterBound(c => c.KeyEncryptionKey))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings == null)
                {
                    vEncryptionSettingsCollection.EncryptionSettings = new List<EncryptionSettingsElement>();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings.Count == 0)
                {
                    vEncryptionSettingsCollection.EncryptionSettings.Add(new EncryptionSettingsElement());
                }

                vEncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey = this.KeyEncryptionKey;
            }

            if (this.IsParameterBound(c => c.DiskEncryptionSetId))
            {
                if (vEncryption == null)
                {
                    vEncryption = new Encryption();
                }
                vEncryption.DiskEncryptionSetId = this.DiskEncryptionSetId;
            }

            if (this.IsParameterBound(c => c.EncryptionType))
            {
                if (vEncryption == null)
                {
                    vEncryption = new Encryption();
                }
                vEncryption.Type = this.EncryptionType;
            }

            if (this.IsParameterBound(c => c.LogicalSectorSize))
            {
                if (vCreationData == null)
                {
                    vCreationData = new CreationData();
                }
                vCreationData.LogicalSectorSize = this.LogicalSectorSize;
            }

            var vDisk = new PSDisk
            {
                Zones = this.IsParameterBound(c => c.Zone) ? this.Zone : null,
                OsType = this.IsParameterBound(c => c.OsType) ? this.OsType : (OperatingSystemTypes?)null,
                HyperVGeneration = this.IsParameterBound(c => c.HyperVGeneration) ? this.HyperVGeneration : null,
                DiskSizeGB = this.IsParameterBound(c => c.DiskSizeGB) ? this.DiskSizeGB : (int?)null,
                DiskIOPSReadWrite = this.IsParameterBound(c => c.DiskIOPSReadWrite) ? this.DiskIOPSReadWrite : (long?)null,
                DiskMBpsReadWrite = this.IsParameterBound(c => c.DiskMBpsReadWrite) ? this.DiskMBpsReadWrite : (long?)null,
                DiskIOPSReadOnly = this.IsParameterBound(c => c.DiskIOPSReadOnly) ? this.DiskIOPSReadOnly : (long?)null,
                DiskMBpsReadOnly = this.IsParameterBound(c => c.DiskMBpsReadOnly) ? this.DiskMBpsReadOnly : (long?)null,
                MaxShares = this.IsParameterBound(c => c.MaxSharesCount) ? this.MaxSharesCount : (int?)null,
                Location = this.IsParameterBound(c => c.Location) ? this.Location : null,
                Tags = this.IsParameterBound(c => c.Tag) ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                Sku = vSku,
                CreationData = vCreationData,
                EncryptionSettingsCollection = vEncryptionSettingsCollection,
                Encryption = vEncryption,
                NetworkAccessPolicy = this.IsParameterBound(c => c.NetworkAccessPolicy) ? this.NetworkAccessPolicy : null,
                DiskAccessId = this.IsParameterBound(c => c.DiskAccessId) ? this.DiskAccessId : null,
                Tier = this.IsParameterBound(c => c.Tier) ? this.Tier : null
            };

            WriteObject(vDisk);
        }
    }
}
