﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using JomMalaysia.Framework.Constant;
using JomMalaysia.Framework.WebServices;
using JomMalaysia.Presentation.Manager;
using JomMalaysia.Presentation.Models.Merchants;
using RestSharp;

namespace JomMalaysia.Presentation.Gateways.Merchants
{
    public class MerchantGateway : IMerchantGateway
    {
        private readonly IWebServiceExecutor _webServiceExecutor;
        private readonly IAuthorizationManagers _authorizationManagers;
        private readonly IApiBuilder _apiBuilder;
        private readonly IMapper _mapper;
        private readonly string auth;

        public MerchantGateway(IWebServiceExecutor webServiceExecutor, IAuthorizationManagers authorizationManagers, IApiBuilder apiBuilder, IMapper mapper)
        {
            _webServiceExecutor = webServiceExecutor;
            _authorizationManagers = authorizationManagers;
            _apiBuilder = apiBuilder;
            _mapper = mapper;
            auth = _authorizationManagers.accessToken;
        }

        public async Task<IWebServiceResponse> CreateMerchant(Merchant vm)
        {
            IWebServiceResponse<Merchant> response;
            try
            {
                var req = _apiBuilder.GetApi((APIConstant.API.Path.Merchant));

                var method = Method.GET;
                response = await _webServiceExecutor.ExecuteRequestAsync<Merchant>(req, method, auth);
            }
            catch (GatewayException ex)
            {
                throw ex;
            }
            return response;


            //handle exception

        }

        public async Task<List<Merchant>> GetMerchants()
        {
            List<Merchant> result = new List<Merchant>();
            IWebServiceResponse<ListViewModel<Merchant>> response = default;

            try
            {
                var req = _apiBuilder.GetApi((APIConstant.API.Path.Merchant));
                var method = Method.GET;
                response = await _webServiceExecutor.ExecuteRequestAsync<ListViewModel<Merchant>>(req, method, auth);

            }
            catch (GatewayException ex)
            {
                throw ex;
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var listings = response.Data.Data;
                foreach (var list in listings)
                {
                    result.Add(list);
                }


            }
            //handle exception
            return result;
        }
    }
}
