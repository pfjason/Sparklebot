# Org.OpenAPITools.Api.UtilsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadChatAsPdfApiV1UtilsPdfPost**](UtilsApi.md#downloadchataspdfapiv1utilspdfpost) | **POST** /api/v1/utils/pdf | Download Chat As Pdf |
| [**DownloadDbApiV1UtilsDbDownloadGet**](UtilsApi.md#downloaddbapiv1utilsdbdownloadget) | **GET** /api/v1/utils/db/download | Download Db |
| [**DownloadLitellmConfigYamlApiV1UtilsLitellmConfigGet**](UtilsApi.md#downloadlitellmconfigyamlapiv1utilslitellmconfigget) | **GET** /api/v1/utils/litellm/config | Download Litellm Config Yaml |
| [**ExecuteCodeApiV1UtilsCodeExecutePost**](UtilsApi.md#executecodeapiv1utilscodeexecutepost) | **POST** /api/v1/utils/code/execute | Execute Code |
| [**FormatCodeApiV1UtilsCodeFormatPost**](UtilsApi.md#formatcodeapiv1utilscodeformatpost) | **POST** /api/v1/utils/code/format | Format Code |
| [**GetGravatarApiV1UtilsGravatarGet**](UtilsApi.md#getgravatarapiv1utilsgravatarget) | **GET** /api/v1/utils/gravatar | Get Gravatar |
| [**GetHtmlFromMarkdownApiV1UtilsMarkdownPost**](UtilsApi.md#gethtmlfrommarkdownapiv1utilsmarkdownpost) | **POST** /api/v1/utils/markdown | Get Html From Markdown |

<a id="downloadchataspdfapiv1utilspdfpost"></a>
# **DownloadChatAsPdfApiV1UtilsPdfPost**
> Object DownloadChatAsPdfApiV1UtilsPdfPost (ChatTitleMessagesForm chatTitleMessagesForm)

Download Chat As Pdf


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatTitleMessagesForm** | [**ChatTitleMessagesForm**](ChatTitleMessagesForm.md) |  |  |

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

<a id="downloaddbapiv1utilsdbdownloadget"></a>
# **DownloadDbApiV1UtilsDbDownloadGet**
> Object DownloadDbApiV1UtilsDbDownloadGet ()

Download Db


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

<a id="downloadlitellmconfigyamlapiv1utilslitellmconfigget"></a>
# **DownloadLitellmConfigYamlApiV1UtilsLitellmConfigGet**
> Object DownloadLitellmConfigYamlApiV1UtilsLitellmConfigGet ()

Download Litellm Config Yaml


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

<a id="executecodeapiv1utilscodeexecutepost"></a>
# **ExecuteCodeApiV1UtilsCodeExecutePost**
> Object ExecuteCodeApiV1UtilsCodeExecutePost (CodeForm codeForm)

Execute Code


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeForm** | [**CodeForm**](CodeForm.md) |  |  |

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

<a id="formatcodeapiv1utilscodeformatpost"></a>
# **FormatCodeApiV1UtilsCodeFormatPost**
> Object FormatCodeApiV1UtilsCodeFormatPost (CodeForm codeForm)

Format Code


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeForm** | [**CodeForm**](CodeForm.md) |  |  |

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

<a id="getgravatarapiv1utilsgravatarget"></a>
# **GetGravatarApiV1UtilsGravatarGet**
> Object GetGravatarApiV1UtilsGravatarGet (string email)

Get Gravatar


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** |  |  |

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

<a id="gethtmlfrommarkdownapiv1utilsmarkdownpost"></a>
# **GetHtmlFromMarkdownApiV1UtilsMarkdownPost**
> Object GetHtmlFromMarkdownApiV1UtilsMarkdownPost (MarkdownForm markdownForm)

Get Html From Markdown


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **markdownForm** | [**MarkdownForm**](MarkdownForm.md) |  |  |

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

