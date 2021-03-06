﻿// ----------------------------------------------------------------------------------
//
// Copyright 2011 Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.Management.CloudService.Model;
using System.IO;

namespace Microsoft.WindowsAzure.Management.CloudService.Test.TestData
{
    class AzureServiceWrapper : AzureService
    {
        public AzureServiceWrapper(string rootPath, string serviceName, string scaffoldingPath) : base(rootPath, serviceName, scaffoldingPath) { }
        
        public AzureServiceWrapper(string rootPath, string scaffoldingPath) : base(rootPath, scaffoldingPath) { }

        public void AddRole(string scaffolding, int webRole, int workerRole)
        {
            for (int i = 0; i < webRole; i++)
            {
                AddWebRole(scaffolding);
            }

            for (int i = 0; i < workerRole; i++)
            {
                AddWorkerRole(scaffolding);
            }
        }

        public void CreateVirtualCloudPackage()
        {
            File.Create(Paths.CloudPackage);
        }
    }
}