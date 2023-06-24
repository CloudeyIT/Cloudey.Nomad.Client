# Cloudey.Nomad.Client.Api.VariablesApi

All URIs are relative to *http://127.0.0.1:4646/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteVariable**](VariablesApi.md#deletevariable) | **DELETE** /var/{path} |  |
| [**GetVariableQuery**](VariablesApi.md#getvariablequery) | **GET** /var/{path} |  |
| [**GetVariablesListRequest**](VariablesApi.md#getvariableslistrequest) | **GET** /vars |  |
| [**PostVariable**](VariablesApi.md#postvariable) | **POST** /var/{path} |  |
| [**PutVariable**](VariablesApi.md#putvariable) | **PUT** /var/{path} |  |

<a id="deletevariable"></a>
# **DeleteVariable**
> void DeleteVariable (string path, Variable variable, string? region = null, string? _namespace = null, string? xNomadToken = null, string? idempotencyToken = null, int? cas = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudey.Nomad.Client.Api;
using Cloudey.Nomad.Client.Client;
using Cloudey.Nomad.Client.Model;

namespace Example
{
    public class DeleteVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VariablesApi(config);
            var path = "path_example";  // string | A path to a Nomad Variable
            var variable = new Variable(); // Variable | 
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var _namespace = "_namespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 
            var cas = 56;  // int? | A compare-and-set parameter for Nomad Variables (optional) 

            try
            {
                apiInstance.DeleteVariable(path, variable, region, _namespace, xNomadToken, idempotencyToken, cas);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.DeleteVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteVariableWithHttpInfo(path, variable, region, _namespace, xNomadToken, idempotencyToken, cas);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.DeleteVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | A path to a Nomad Variable |  |
| **variable** | [**Variable**](Variable.md) |  |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **_namespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |
| **cas** | **int?** | A compare-and-set parameter for Nomad Variables | [optional]  |

### Return type

void (empty response body)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvariablequery"></a>
# **GetVariableQuery**
> Variable GetVariableQuery (string path, string? region = null, string? _namespace = null, int? index = null, string? wait = null, string? stale = null, string? prefix = null, string? xNomadToken = null, int? perPage = null, string? nextToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudey.Nomad.Client.Api;
using Cloudey.Nomad.Client.Client;
using Cloudey.Nomad.Client.Model;

namespace Example
{
    public class GetVariableQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VariablesApi(config);
            var path = "path_example";  // string | A path to a Nomad Variable
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var _namespace = "_namespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var index = 56;  // int? | If set, wait until query exceeds given index. Must be provided with WaitParam. (optional) 
            var wait = "wait_example";  // string? | Provided with IndexParam to wait for change. (optional) 
            var stale = "stale_example";  // string? | If present, results will include stale reads. (optional) 
            var prefix = "prefix_example";  // string? | Constrains results to jobs that start with the defined prefix (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var perPage = 56;  // int? | Maximum number of results to return. (optional) 
            var nextToken = "nextToken_example";  // string? | Indicates where to start paging for queries that support pagination. (optional) 

            try
            {
                Variable result = apiInstance.GetVariableQuery(path, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.GetVariableQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVariableQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Variable> response = apiInstance.GetVariableQueryWithHttpInfo(path, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.GetVariableQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | A path to a Nomad Variable |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **_namespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **index** | **int?** | If set, wait until query exceeds given index. Must be provided with WaitParam. | [optional]  |
| **wait** | **string?** | Provided with IndexParam to wait for change. | [optional]  |
| **stale** | **string?** | If present, results will include stale reads. | [optional]  |
| **prefix** | **string?** | Constrains results to jobs that start with the defined prefix | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **perPage** | **int?** | Maximum number of results to return. | [optional]  |
| **nextToken** | **string?** | Indicates where to start paging for queries that support pagination. | [optional]  |

### Return type

[**Variable**](Variable.md)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  * X-Nomad-KnownLeader - Boolean indicating if there is a known cluster leader. <br>  * X-Nomad-LastContact - The time in milliseconds that a server was last contacted by the leader node. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvariableslistrequest"></a>
# **GetVariablesListRequest**
> List&lt;VariableMetadata&gt; GetVariablesListRequest (string? region = null, string? _namespace = null, int? index = null, string? wait = null, string? stale = null, string? prefix = null, string? xNomadToken = null, int? perPage = null, string? nextToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudey.Nomad.Client.Api;
using Cloudey.Nomad.Client.Client;
using Cloudey.Nomad.Client.Model;

namespace Example
{
    public class GetVariablesListRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VariablesApi(config);
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var _namespace = "_namespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var index = 56;  // int? | If set, wait until query exceeds given index. Must be provided with WaitParam. (optional) 
            var wait = "wait_example";  // string? | Provided with IndexParam to wait for change. (optional) 
            var stale = "stale_example";  // string? | If present, results will include stale reads. (optional) 
            var prefix = "prefix_example";  // string? | Constrains results to jobs that start with the defined prefix (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var perPage = 56;  // int? | Maximum number of results to return. (optional) 
            var nextToken = "nextToken_example";  // string? | Indicates where to start paging for queries that support pagination. (optional) 

            try
            {
                List<VariableMetadata> result = apiInstance.GetVariablesListRequest(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.GetVariablesListRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVariablesListRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VariableMetadata>> response = apiInstance.GetVariablesListRequestWithHttpInfo(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.GetVariablesListRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **_namespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **index** | **int?** | If set, wait until query exceeds given index. Must be provided with WaitParam. | [optional]  |
| **wait** | **string?** | Provided with IndexParam to wait for change. | [optional]  |
| **stale** | **string?** | If present, results will include stale reads. | [optional]  |
| **prefix** | **string?** | Constrains results to jobs that start with the defined prefix | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **perPage** | **int?** | Maximum number of results to return. | [optional]  |
| **nextToken** | **string?** | Indicates where to start paging for queries that support pagination. | [optional]  |

### Return type

[**List&lt;VariableMetadata&gt;**](VariableMetadata.md)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  * X-Nomad-KnownLeader - Boolean indicating if there is a known cluster leader. <br>  * X-Nomad-LastContact - The time in milliseconds that a server was last contacted by the leader node. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postvariable"></a>
# **PostVariable**
> Variable PostVariable (string path, Variable variable, string? region = null, string? _namespace = null, string? xNomadToken = null, string? idempotencyToken = null, int? cas = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudey.Nomad.Client.Api;
using Cloudey.Nomad.Client.Client;
using Cloudey.Nomad.Client.Model;

namespace Example
{
    public class PostVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VariablesApi(config);
            var path = "path_example";  // string | A path to a Nomad Variable
            var variable = new Variable(); // Variable | 
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var _namespace = "_namespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 
            var cas = 56;  // int? | A compare-and-set parameter for Nomad Variables (optional) 

            try
            {
                Variable result = apiInstance.PostVariable(path, variable, region, _namespace, xNomadToken, idempotencyToken, cas);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.PostVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Variable> response = apiInstance.PostVariableWithHttpInfo(path, variable, region, _namespace, xNomadToken, idempotencyToken, cas);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.PostVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | A path to a Nomad Variable |  |
| **variable** | [**Variable**](Variable.md) |  |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **_namespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |
| **cas** | **int?** | A compare-and-set parameter for Nomad Variables | [optional]  |

### Return type

[**Variable**](Variable.md)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putvariable"></a>
# **PutVariable**
> Variable PutVariable (string path, Variable variable, string? region = null, string? _namespace = null, string? xNomadToken = null, string? idempotencyToken = null, int? cas = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudey.Nomad.Client.Api;
using Cloudey.Nomad.Client.Client;
using Cloudey.Nomad.Client.Model;

namespace Example
{
    public class PutVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VariablesApi(config);
            var path = "path_example";  // string | A path to a Nomad Variable
            var variable = new Variable(); // Variable | 
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var _namespace = "_namespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 
            var cas = 56;  // int? | A compare-and-set parameter for Nomad Variables (optional) 

            try
            {
                Variable result = apiInstance.PutVariable(path, variable, region, _namespace, xNomadToken, idempotencyToken, cas);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.PutVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Variable> response = apiInstance.PutVariableWithHttpInfo(path, variable, region, _namespace, xNomadToken, idempotencyToken, cas);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.PutVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | A path to a Nomad Variable |  |
| **variable** | [**Variable**](Variable.md) |  |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **_namespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |
| **cas** | **int?** | A compare-and-set parameter for Nomad Variables | [optional]  |

### Return type

[**Variable**](Variable.md)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

