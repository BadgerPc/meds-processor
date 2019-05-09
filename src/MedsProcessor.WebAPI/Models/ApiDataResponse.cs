using System;

namespace MedsProcessor.WebAPI.Models
{
	public class ApiDataResponse<TObjectModel> : ApiMessageResponse
	{
		public TObjectModel Data { get; }

		public ApiDataResponse(int statusCode, TObjectModel model, string message = null) : base(statusCode, message)
		{
			if (model == default)
			{
				throw new ArgumentNullException("Response object model data can not be null or of default value for the given model data.");
			}

			Data = model;
		}
	}
}