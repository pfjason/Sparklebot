# Org.OpenAPITools.Api.PromptsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewPromptApiV1PromptsCreatePost**](PromptsApi.md#createnewpromptapiv1promptscreatepost) | **POST** /api/v1/prompts/create | Create New Prompt |
| [**DeletePromptByCommandApiV1PromptsCommandCommandDeleteDelete**](PromptsApi.md#deletepromptbycommandapiv1promptscommandcommanddeletedelete) | **DELETE** /api/v1/prompts/command/{command}/delete | Delete Prompt By Command |
| [**GetPromptByCommandApiV1PromptsCommandCommandGet**](PromptsApi.md#getpromptbycommandapiv1promptscommandcommandget) | **GET** /api/v1/prompts/command/{command} | Get Prompt By Command |
| [**GetPromptListApiV1PromptsListGet**](PromptsApi.md#getpromptlistapiv1promptslistget) | **GET** /api/v1/prompts/list | Get Prompt List |
| [**GetPromptsApiV1PromptsGet**](PromptsApi.md#getpromptsapiv1promptsget) | **GET** /api/v1/prompts/ | Get Prompts |
| [**UpdatePromptByCommandApiV1PromptsCommandCommandUpdatePost**](PromptsApi.md#updatepromptbycommandapiv1promptscommandcommandupdatepost) | **POST** /api/v1/prompts/command/{command}/update | Update Prompt By Command |

<a id="createnewpromptapiv1promptscreatepost"></a>
# **CreateNewPromptApiV1PromptsCreatePost**
> PromptModel CreateNewPromptApiV1PromptsCreatePost (PromptForm promptForm)

Create New Prompt


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **promptForm** | [**PromptForm**](PromptForm.md) |  |  |

### Return type

[**PromptModel**](PromptModel.md)

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

<a id="deletepromptbycommandapiv1promptscommandcommanddeletedelete"></a>
# **DeletePromptByCommandApiV1PromptsCommandCommandDeleteDelete**
> bool DeletePromptByCommandApiV1PromptsCommandCommandDeleteDelete (string command)

Delete Prompt By Command


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **command** | **string** |  |  |

### Return type

**bool**

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

<a id="getpromptbycommandapiv1promptscommandcommandget"></a>
# **GetPromptByCommandApiV1PromptsCommandCommandGet**
> PromptModel GetPromptByCommandApiV1PromptsCommandCommandGet (string command)

Get Prompt By Command


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **command** | **string** |  |  |

### Return type

[**PromptModel**](PromptModel.md)

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

<a id="getpromptlistapiv1promptslistget"></a>
# **GetPromptListApiV1PromptsListGet**
> List&lt;PromptUserResponse&gt; GetPromptListApiV1PromptsListGet ()

Get Prompt List


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PromptUserResponse&gt;**](PromptUserResponse.md)

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

<a id="getpromptsapiv1promptsget"></a>
# **GetPromptsApiV1PromptsGet**
> List&lt;PromptModel&gt; GetPromptsApiV1PromptsGet ()

Get Prompts


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PromptModel&gt;**](PromptModel.md)

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

<a id="updatepromptbycommandapiv1promptscommandcommandupdatepost"></a>
# **UpdatePromptByCommandApiV1PromptsCommandCommandUpdatePost**
> PromptModel UpdatePromptByCommandApiV1PromptsCommandCommandUpdatePost (string command, PromptForm promptForm)

Update Prompt By Command


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **command** | **string** |  |  |
| **promptForm** | [**PromptForm**](PromptForm.md) |  |  |

### Return type

[**PromptModel**](PromptModel.md)

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

