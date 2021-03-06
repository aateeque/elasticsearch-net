﻿using System;
using System.Linq.Expressions;

namespace Nest
{
	public class IPMappingDescriptor<T>
	{
		internal IPMapping _Mapping = new IPMapping();

		public IPMappingDescriptor<T> Name(string name)
		{
			this._Mapping.Name = name;
			return this;
		}
		public IPMappingDescriptor<T> Name(Expression<Func<T, object>> objectPath)
		{
			this._Mapping.Name = objectPath;
			return this;
		}

		public IPMappingDescriptor<T> IndexName(string indexName)
		{
			this._Mapping.IndexName = indexName;
			return this;
		}
		public IPMappingDescriptor<T> NoIndex()
		{
			this._Mapping.Index = false;
			return this;
		}
		public IPMappingDescriptor<T> Store(bool store = true)
		{
			this._Mapping.Store = store;
			return this;
		}

		
		public IPMappingDescriptor<T> Boost(double boost)
		{
			this._Mapping.Boost = boost;
			return this;
		}
		public IPMappingDescriptor<T> NullValue(string nullValue)
		{
			this._Mapping.NullValue = nullValue;
			return this;
		}

		public IPMappingDescriptor<T> PrecisionStep(int precisionStep)
		{
			this._Mapping.PrecisionStep = precisionStep;
			return this;
		}

		public IPMappingDescriptor<T> IncludeInAll(bool includeInAll = true)
		{
			this._Mapping.IncludeInAll = includeInAll;
			return this;
		}
		

	}
}