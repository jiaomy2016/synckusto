﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace SyncKusto.ChangeModel
{
    public class FunctionSchemaDifference : SchemaDifference
    {
        public FunctionSchemaDifference(Difference difference, IKustoSchema value) : base(difference) => Value = value;

        private IKustoSchema Value { get; }

        public override IKustoSchema Schema => Value;

        public override string Name => Value.Name;
    }
}