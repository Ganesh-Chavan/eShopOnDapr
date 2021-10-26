﻿global using HealthChecks.UI.Client;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.eShopOnDapr.Services.Basket.API;
global using Microsoft.eShopOnDapr.BuildingBlocks.EventBus;
global using Microsoft.eShopOnDapr.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.eShopOnDapr.Services.Basket.API.Infrastructure.Filters;
global using Microsoft.eShopOnDapr.Services.Basket.API.Infrastructure.Repositories;
global using Microsoft.eShopOnDapr.Services.Basket.API.IntegrationEvents.EventHandling;
global using Microsoft.eShopOnDapr.Services.Basket.API.IntegrationEvents.Events;
global using Microsoft.eShopOnDapr.BuildingBlocks.EventBus.Events;
global using Microsoft.eShopOnDapr.Services.Basket.API.Model;
global using Microsoft.eShopOnDapr.Services.Basket.API.Services;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.OpenApi.Models;
global using Serilog;
global using System.IdentityModel.Tokens.Jwt;
global using System.ComponentModel.DataAnnotations;
global using Microsoft.AspNetCore.Authorization;
global using Swashbuckle.AspNetCore.SwaggerGen;
global using Dapr.Client;
global using Microsoft.AspNetCore.Mvc;
global using System.Net;
global using Dapr;