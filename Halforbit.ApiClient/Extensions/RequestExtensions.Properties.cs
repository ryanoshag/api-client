﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Halforbit.ApiClient
{
    public static partial class RequestExtensions
    {
        public static Request Services(
            this Request request,
            RequestServices requestServices)
        {
            request = request ?? Request.Default;

            return new Request(
                services: requestServices,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request BaseUrl(
            this Request request,
            string baseUrl)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: baseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request Method(
            this Request request,
            string method)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request Resource(
            this Request request,
            string resource)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request RouteValue(
            this Request request,
            string key,
            string value)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues.With(key, value),
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request RouteValues(
            this Request request,
            object values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues.With(values),
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request RouteValues(
            this Request request,
            params (string Key, string Value)[] values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues.With(values),
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request RouteValues(
            this Request request,
            IReadOnlyDictionary<string, string> values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues.With(values),
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request QueryValue(
            this Request request,
            string key,
            string value)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues.With(key, value),
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request QueryValues(
            this Request request,
            object values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues.With(values),
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request QueryValues(
            this Request request,
            params (string Key, string Value)[] values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues.With(values),
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request QueryValues(
            this Request request,
            IReadOnlyDictionary<string, string> values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues.With(values),
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request Header(
            this Request request,
            string key,
            string value)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers.With(key, value),
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request Headers(
            this Request request,
            object values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers.With(values),
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request Headers(
            this Request request,
            params (string Key, string Value)[] values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers.With(values),
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request Headers(
            this Request request,
            IReadOnlyDictionary<string, string> values)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers.With(values),
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request ContentType(
            this Request request,
            string contentType)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: contentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request ContentEncoding(
            this Request request,
            string contentEncoding)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: contentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request Authentication(
            this Request request,
            string authentication)
        {
            request = request ?? Request.Default;

            return request.Header("Authentication", authentication);
        }

        public static Request Cookie(
            this Request request,
            string cookie)
        {
            request = request ?? Request.Default;

            return request.Header("Cookie", cookie);
        }

        public static Request Timeout(
            this Request request,
            TimeSpan timeout)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags);
        }

        public static Request Allow(
            this Request request,
            params HttpStatusCode[] statusCodes)
        {
            request = request ?? Request.Default;

            var expectedStatusCodes = new HashSet<HttpStatusCode>(request.AllowedStatusCodes);

            foreach(var statusCode in statusCodes)
            {
                expectedStatusCodes.Add(statusCode);
            }

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: expectedStatusCodes,
                tags: request.Tags);
        }

        public static Request AllowNotFound(
            this Request request)
        {
            request = request ?? Request.Default;

            return request.Allow(HttpStatusCode.NotFound);
        }

        public static Request AllowAnyStatusCode(
            this Request request)
        {
            request = request ?? Request.Default;

            return request.Allow(new HttpStatusCode[] { 0 }.Concat(Enum
                .GetValues(typeof(HttpStatusCode))
                .Cast<HttpStatusCode>())
                .ToArray());
        }

        public static Request Tag<TValue>(
            this Request request,
            string key, 
            TValue value)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags.With(key, value));
        }

        public static Request Tag(
            this Request request,
            IReadOnlyDictionary<string, object> tags)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags.With(tags));
        }

        public static Request Tag<TValue>(
            this Request request,
            params (string Key, object Value)[] tags)
        {
            request = request ?? Request.Default;

            return new Request(
                services: request.Services,
                baseUrl: request.BaseUrl,
                method: request.Method,
                resource: request.Resource,
                headers: request.Headers,
                routeValues: request.RouteValues,
                queryValues: request.QueryValues,
                content: request.Content,
                contentType: request.ContentType,
                contentEncoding: request.ContentEncoding,
                timeout: request.Timeout,
                allowedStatusCodes: request.AllowedStatusCodes,
                tags: request.Tags.With(tags));
        }

        public static TValue Tag<TValue>(
            this Request request, 
            string key)
        {
            return request.Tags.TryGetValue(key, out var value) ? 
                (TValue)value : 
                default;
        }

        public static Request Name(
            this Request request,
            string name)
        {
            request = request ?? Request.Default;

            return request.Tag(nameof(Name), name);
        }

        public static string Name(this Request request)
        {
            return request.Tag<string>(nameof(Name));
        }
    }
}