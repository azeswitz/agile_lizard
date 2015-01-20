// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.B
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using StructureMap;
using StructureMap.Graph;
using AgileLizard.Data.Interfaces;
using AgileLizard.Data.Repositories;
using AgileLizard.Domain;
using AgileLizard.Business.Interfaces;
using AgileLizard.Business.Managers;
using AgileLizard.Fbopen.Client.Interfaces;
using AgileLizard.Fbopen.Client.Managers;

namespace AgileLizard.Site.DependencyResolution {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<System.Data.Entity.DbContext>().Singleton().Use<AgileLizard.Data.Entities>();
                            x.For<IGenericDataRepository<Demo>>().Use<GenericDataRepository<Demo>>();
                            x.For<IGenericDataRepository<Procurement>>().Use<GenericDataRepository<Procurement>>();
                            x.For<IGenericDataRepository<FboProfile>>().Use<GenericDataRepository<FboProfile>>();
                            x.For<IGenericDataRepository<FactRequestType>>().Use<GenericDataRepository<FactRequestType>>();
                            x.For<IGenericDataRepository<FactSetAside>>().Use<GenericDataRepository<FactSetAside>>();

                            x.For<IProcurementManager>().Use<ProcurementManager>();
                            x.For<IFboProfileManager>().Use<FboProfileManager>();

                            x.For<IFactManager>().Use<FactManager>();


                            //FBOpen Client
                            x.For<IDocumentManager>().Use<DocumentManager>();

                        });
            return ObjectFactory.Container;
        }
    }
}