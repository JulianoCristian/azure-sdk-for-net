﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.Fluent.Resource;
using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
using Microsoft.Azure.Management.ResourceManager.Fluent;

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{
    internal class SubscriptionImpl :
        IndexableWrapper<SubscriptionInner>,
        ISubscription
    {
        private ISubscriptionsOperations innerCollection;

        internal SubscriptionImpl(SubscriptionInner innerModel, ISubscriptionsOperations client) : base(innerModel)
        {
            innerCollection = client;
        }

        public string DisplayName
        {
            get
            {
                return Inner.DisplayName;
            }
        }

        public string State
        {
            get
            {
                return Inner.State;
            }
        }

        public string SubscriptionId
        {
            get
            {
                return Inner.SubscriptionId;
            }
        }

        public SubscriptionPolicies SubscriptionPolicies
        {
            get
            {
                return Inner.SubscriptionPolicies;
            }
        }

        public ILocation GetLocationByRegion(Region region)
        {
            if (region != null)
            {
                var locations = ListLocations();
                foreach (var location in locations)
                {
                    if (region.Equals(location.Region))
                    {
                        return location;
                    }
                }
            }
            return null;
        }

        public PagedList<ILocation> ListLocations()
        {
            var innerList = new PagedList<Location>(innerCollection.ListLocations(SubscriptionId));
            return PagedListConverter.Convert<Location, ILocation>(innerList, innerLocation => {
                return new LocationImpl(innerLocation); 
            });
        }
    }
}