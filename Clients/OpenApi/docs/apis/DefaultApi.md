# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChatActionApiChatActionsActionIdPost**](DefaultApi.md#chatactionapichatactionsactionidpost) | **POST** /api/chat/actions/{action_id} | Chat Action |
| [**ChatCompletedApiChatCompletedPost**](DefaultApi.md#chatcompletedapichatcompletedpost) | **POST** /api/chat/completed | Chat Completed |
| [**ChatCompletionApiChatCompletionsPost**](DefaultApi.md#chatcompletionapichatcompletionspost) | **POST** /api/chat/completions | Chat Completion |
| [**EmbeddingsApiEmbeddingsPost**](DefaultApi.md#embeddingsapiembeddingspost) | **POST** /api/embeddings | Embeddings |
| [**GetAppChangelogApiChangelogGet**](DefaultApi.md#getappchangelogapichangelogget) | **GET** /api/changelog | Get App Changelog |
| [**GetAppConfigApiConfigGet**](DefaultApi.md#getappconfigapiconfigget) | **GET** /api/config | Get App Config |
| [**GetAppLatestReleaseVersionApiVersionUpdatesGet**](DefaultApi.md#getapplatestreleaseversionapiversionupdatesget) | **GET** /api/version/updates | Get App Latest Release Version |
| [**GetAppVersionApiVersionGet**](DefaultApi.md#getappversionapiversionget) | **GET** /api/version | Get App Version |
| [**GetBaseModelsApiModelsBaseGet**](DefaultApi.md#getbasemodelsapimodelsbaseget) | **GET** /api/models/base | Get Base Models |
| [**GetCurrentUsageApiUsageGet**](DefaultApi.md#getcurrentusageapiusageget) | **GET** /api/usage | Get Current Usage |
| [**GetManifestJsonManifestJsonGet**](DefaultApi.md#getmanifestjsonmanifestjsonget) | **GET** /manifest.json | Get Manifest Json |
| [**GetModelsApiModelsGet**](DefaultApi.md#getmodelsapimodelsget) | **GET** /api/models | Get Models |
| [**GetOpensearchXmlOpensearchXmlGet**](DefaultApi.md#getopensearchxmlopensearchxmlget) | **GET** /opensearch.xml | Get Opensearch Xml |
| [**GetWebhookUrlApiWebhookGet**](DefaultApi.md#getwebhookurlapiwebhookget) | **GET** /api/webhook | Get Webhook Url |
| [**HealthcheckHealthGet**](DefaultApi.md#healthcheckhealthget) | **GET** /health | Healthcheck |
| [**HealthcheckWithDbHealthDbGet**](DefaultApi.md#healthcheckwithdbhealthdbget) | **GET** /health/db | Healthcheck With Db |
| [**ListTasksByChatIdEndpointApiTasksChatChatIdGet**](DefaultApi.md#listtasksbychatidendpointapitaskschatchatidget) | **GET** /api/tasks/chat/{chat_id} | List Tasks By Chat Id Endpoint |
| [**ListTasksEndpointApiTasksGet**](DefaultApi.md#listtasksendpointapitasksget) | **GET** /api/tasks | List Tasks Endpoint |
| [**OauthCallbackOauthProviderCallbackGet**](DefaultApi.md#oauthcallbackoauthprovidercallbackget) | **GET** /oauth/{provider}/callback | Oauth Callback |
| [**OauthLoginOauthProviderLoginGet**](DefaultApi.md#oauthloginoauthproviderloginget) | **GET** /oauth/{provider}/login | Oauth Login |
| [**ServeCacheFileCachePathGet**](DefaultApi.md#servecachefilecachepathget) | **GET** /cache/{path} | Serve Cache File |
| [**StopTaskEndpointApiTasksStopTaskIdPost**](DefaultApi.md#stoptaskendpointapitasksstoptaskidpost) | **POST** /api/tasks/stop/{task_id} | Stop Task Endpoint |
| [**UpdateWebhookUrlApiWebhookPost**](DefaultApi.md#updatewebhookurlapiwebhookpost) | **POST** /api/webhook | Update Webhook Url |

<a id="chatactionapichatactionsactionidpost"></a>
# **ChatActionApiChatActionsActionIdPost**
> Object ChatActionApiChatActionsActionIdPost (string actionId, Object body)

Chat Action


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actionId** | **string** |  |  |
| **body** | **Object** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="chatcompletedapichatcompletedpost"></a>
# **ChatCompletedApiChatCompletedPost**
> Object ChatCompletedApiChatCompletedPost (Object body)

Chat Completed


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="chatcompletionapichatcompletionspost"></a>
# **ChatCompletionApiChatCompletionsPost**
> Object ChatCompletionApiChatCompletionsPost (Object body)

Chat Completion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="embeddingsapiembeddingspost"></a>
# **EmbeddingsApiEmbeddingsPost**
> Object EmbeddingsApiEmbeddingsPost (Object body)

Embeddings

OpenAI-compatible embeddings endpoint.  This handler:   - Performs user/model checks and dispatches to the correct backend.   - Supports OpenAI, Ollama, arena models, pipelines, and any compatible provider.  Args:     request (Request): Request context.     form_data (dict): OpenAI-like payload (e.g., {\"model\": \"...\", \"input\": [...]})     user (UserModel): Authenticated user.  Returns:     dict: OpenAI-compatible embeddings response.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getappchangelogapichangelogget"></a>
# **GetAppChangelogApiChangelogGet**
> Object GetAppChangelogApiChangelogGet ()

Get App Changelog


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getappconfigapiconfigget"></a>
# **GetAppConfigApiConfigGet**
> Object GetAppConfigApiConfigGet ()

Get App Config


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplatestreleaseversionapiversionupdatesget"></a>
# **GetAppLatestReleaseVersionApiVersionUpdatesGet**
> Object GetAppLatestReleaseVersionApiVersionUpdatesGet ()

Get App Latest Release Version


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getappversionapiversionget"></a>
# **GetAppVersionApiVersionGet**
> Object GetAppVersionApiVersionGet ()

Get App Version


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbasemodelsapimodelsbaseget"></a>
# **GetBaseModelsApiModelsBaseGet**
> Object GetBaseModelsApiModelsBaseGet ()

Get Base Models


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcurrentusageapiusageget"></a>
# **GetCurrentUsageApiUsageGet**
> Object GetCurrentUsageApiUsageGet ()

Get Current Usage

Get current usage statistics for Open WebUI. This is an experimental endpoint and subject to change.


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmanifestjsonmanifestjsonget"></a>
# **GetManifestJsonManifestJsonGet**
> Object GetManifestJsonManifestJsonGet ()

Get Manifest Json


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmodelsapimodelsget"></a>
# **GetModelsApiModelsGet**
> Object GetModelsApiModelsGet ()

Get Models


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getopensearchxmlopensearchxmlget"></a>
# **GetOpensearchXmlOpensearchXmlGet**
> Object GetOpensearchXmlOpensearchXmlGet ()

Get Opensearch Xml


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhookurlapiwebhookget"></a>
# **GetWebhookUrlApiWebhookGet**
> Object GetWebhookUrlApiWebhookGet ()

Get Webhook Url


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="healthcheckhealthget"></a>
# **HealthcheckHealthGet**
> Object HealthcheckHealthGet ()

Healthcheck


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="healthcheckwithdbhealthdbget"></a>
# **HealthcheckWithDbHealthDbGet**
> Object HealthcheckWithDbHealthDbGet ()

Healthcheck With Db


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtasksbychatidendpointapitaskschatchatidget"></a>
# **ListTasksByChatIdEndpointApiTasksChatChatIdGet**
> Object ListTasksByChatIdEndpointApiTasksChatChatIdGet (string chatId)

List Tasks By Chat Id Endpoint


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatId** | **string** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtasksendpointapitasksget"></a>
# **ListTasksEndpointApiTasksGet**
> Object ListTasksEndpointApiTasksGet ()

List Tasks Endpoint


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="oauthcallbackoauthprovidercallbackget"></a>
# **OauthCallbackOauthProviderCallbackGet**
> Object OauthCallbackOauthProviderCallbackGet (string provider)

Oauth Callback


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **string** |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="oauthloginoauthproviderloginget"></a>
# **OauthLoginOauthProviderLoginGet**
> Object OauthLoginOauthProviderLoginGet (string provider)

Oauth Login


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **string** |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="servecachefilecachepathget"></a>
# **ServeCacheFileCachePathGet**
> Object ServeCacheFileCachePathGet (string path)

Serve Cache File


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stoptaskendpointapitasksstoptaskidpost"></a>
# **StopTaskEndpointApiTasksStopTaskIdPost**
> Object StopTaskEndpointApiTasksStopTaskIdPost (string taskId)

Stop Task Endpoint


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **string** |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatewebhookurlapiwebhookpost"></a>
# **UpdateWebhookUrlApiWebhookPost**
> Object UpdateWebhookUrlApiWebhookPost (UrlForm urlForm)

Update Webhook Url


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlForm** | [**UrlForm**](UrlForm.md) |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

