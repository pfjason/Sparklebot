# Org.OpenAPITools.Api.ConfigsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportConfigApiV1ConfigsExportGet**](ConfigsApi.md#exportconfigapiv1configsexportget) | **GET** /api/v1/configs/export | Export Config |
| [**GetBannersApiV1ConfigsBannersGet**](ConfigsApi.md#getbannersapiv1configsbannersget) | **GET** /api/v1/configs/banners | Get Banners |
| [**GetCodeExecutionConfigApiV1ConfigsCodeExecutionGet**](ConfigsApi.md#getcodeexecutionconfigapiv1configscodeexecutionget) | **GET** /api/v1/configs/code_execution | Get Code Execution Config |
| [**GetDirectConnectionsConfigApiV1ConfigsDirectConnectionsGet**](ConfigsApi.md#getdirectconnectionsconfigapiv1configsdirectconnectionsget) | **GET** /api/v1/configs/direct_connections | Get Direct Connections Config |
| [**GetModelsConfigApiV1ConfigsModelsGet**](ConfigsApi.md#getmodelsconfigapiv1configsmodelsget) | **GET** /api/v1/configs/models | Get Models Config |
| [**GetToolServersConfigApiV1ConfigsToolServersGet**](ConfigsApi.md#gettoolserversconfigapiv1configstoolserversget) | **GET** /api/v1/configs/tool_servers | Get Tool Servers Config |
| [**ImportConfigApiV1ConfigsImportPost**](ConfigsApi.md#importconfigapiv1configsimportpost) | **POST** /api/v1/configs/import | Import Config |
| [**SetBannersApiV1ConfigsBannersPost**](ConfigsApi.md#setbannersapiv1configsbannerspost) | **POST** /api/v1/configs/banners | Set Banners |
| [**SetCodeExecutionConfigApiV1ConfigsCodeExecutionPost**](ConfigsApi.md#setcodeexecutionconfigapiv1configscodeexecutionpost) | **POST** /api/v1/configs/code_execution | Set Code Execution Config |
| [**SetDefaultSuggestionsApiV1ConfigsSuggestionsPost**](ConfigsApi.md#setdefaultsuggestionsapiv1configssuggestionspost) | **POST** /api/v1/configs/suggestions | Set Default Suggestions |
| [**SetDirectConnectionsConfigApiV1ConfigsDirectConnectionsPost**](ConfigsApi.md#setdirectconnectionsconfigapiv1configsdirectconnectionspost) | **POST** /api/v1/configs/direct_connections | Set Direct Connections Config |
| [**SetModelsConfigApiV1ConfigsModelsPost**](ConfigsApi.md#setmodelsconfigapiv1configsmodelspost) | **POST** /api/v1/configs/models | Set Models Config |
| [**SetToolServersConfigApiV1ConfigsToolServersPost**](ConfigsApi.md#settoolserversconfigapiv1configstoolserverspost) | **POST** /api/v1/configs/tool_servers | Set Tool Servers Config |
| [**VerifyToolServersConfigApiV1ConfigsToolServersVerifyPost**](ConfigsApi.md#verifytoolserversconfigapiv1configstoolserversverifypost) | **POST** /api/v1/configs/tool_servers/verify | Verify Tool Servers Config |

<a id="exportconfigapiv1configsexportget"></a>
# **ExportConfigApiV1ConfigsExportGet**
> Object ExportConfigApiV1ConfigsExportGet ()

Export Config


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

<a id="getbannersapiv1configsbannersget"></a>
# **GetBannersApiV1ConfigsBannersGet**
> List&lt;BannerModel&gt; GetBannersApiV1ConfigsBannersGet ()

Get Banners


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;BannerModel&gt;**](BannerModel.md)

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

<a id="getcodeexecutionconfigapiv1configscodeexecutionget"></a>
# **GetCodeExecutionConfigApiV1ConfigsCodeExecutionGet**
> CodeInterpreterConfigForm GetCodeExecutionConfigApiV1ConfigsCodeExecutionGet ()

Get Code Execution Config


### Parameters
This endpoint does not need any parameter.
### Return type

[**CodeInterpreterConfigForm**](CodeInterpreterConfigForm.md)

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

<a id="getdirectconnectionsconfigapiv1configsdirectconnectionsget"></a>
# **GetDirectConnectionsConfigApiV1ConfigsDirectConnectionsGet**
> DirectConnectionsConfigForm GetDirectConnectionsConfigApiV1ConfigsDirectConnectionsGet ()

Get Direct Connections Config


### Parameters
This endpoint does not need any parameter.
### Return type

[**DirectConnectionsConfigForm**](DirectConnectionsConfigForm.md)

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

<a id="getmodelsconfigapiv1configsmodelsget"></a>
# **GetModelsConfigApiV1ConfigsModelsGet**
> ModelsConfigForm GetModelsConfigApiV1ConfigsModelsGet ()

Get Models Config


### Parameters
This endpoint does not need any parameter.
### Return type

[**ModelsConfigForm**](ModelsConfigForm.md)

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

<a id="gettoolserversconfigapiv1configstoolserversget"></a>
# **GetToolServersConfigApiV1ConfigsToolServersGet**
> ToolServersConfigForm GetToolServersConfigApiV1ConfigsToolServersGet ()

Get Tool Servers Config


### Parameters
This endpoint does not need any parameter.
### Return type

[**ToolServersConfigForm**](ToolServersConfigForm.md)

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

<a id="importconfigapiv1configsimportpost"></a>
# **ImportConfigApiV1ConfigsImportPost**
> Object ImportConfigApiV1ConfigsImportPost (ImportConfigForm importConfigForm)

Import Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **importConfigForm** | [**ImportConfigForm**](ImportConfigForm.md) |  |  |

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

<a id="setbannersapiv1configsbannerspost"></a>
# **SetBannersApiV1ConfigsBannersPost**
> List&lt;BannerModel&gt; SetBannersApiV1ConfigsBannersPost (SetBannersForm setBannersForm)

Set Banners


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setBannersForm** | [**SetBannersForm**](SetBannersForm.md) |  |  |

### Return type

[**List&lt;BannerModel&gt;**](BannerModel.md)

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

<a id="setcodeexecutionconfigapiv1configscodeexecutionpost"></a>
# **SetCodeExecutionConfigApiV1ConfigsCodeExecutionPost**
> CodeInterpreterConfigForm SetCodeExecutionConfigApiV1ConfigsCodeExecutionPost (CodeInterpreterConfigForm codeInterpreterConfigForm)

Set Code Execution Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeInterpreterConfigForm** | [**CodeInterpreterConfigForm**](CodeInterpreterConfigForm.md) |  |  |

### Return type

[**CodeInterpreterConfigForm**](CodeInterpreterConfigForm.md)

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

<a id="setdefaultsuggestionsapiv1configssuggestionspost"></a>
# **SetDefaultSuggestionsApiV1ConfigsSuggestionsPost**
> List&lt;PromptSuggestion&gt; SetDefaultSuggestionsApiV1ConfigsSuggestionsPost (SetDefaultSuggestionsForm setDefaultSuggestionsForm)

Set Default Suggestions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setDefaultSuggestionsForm** | [**SetDefaultSuggestionsForm**](SetDefaultSuggestionsForm.md) |  |  |

### Return type

[**List&lt;PromptSuggestion&gt;**](PromptSuggestion.md)

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

<a id="setdirectconnectionsconfigapiv1configsdirectconnectionspost"></a>
# **SetDirectConnectionsConfigApiV1ConfigsDirectConnectionsPost**
> DirectConnectionsConfigForm SetDirectConnectionsConfigApiV1ConfigsDirectConnectionsPost (DirectConnectionsConfigForm directConnectionsConfigForm)

Set Direct Connections Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **directConnectionsConfigForm** | [**DirectConnectionsConfigForm**](DirectConnectionsConfigForm.md) |  |  |

### Return type

[**DirectConnectionsConfigForm**](DirectConnectionsConfigForm.md)

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

<a id="setmodelsconfigapiv1configsmodelspost"></a>
# **SetModelsConfigApiV1ConfigsModelsPost**
> ModelsConfigForm SetModelsConfigApiV1ConfigsModelsPost (ModelsConfigForm modelsConfigForm)

Set Models Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelsConfigForm** | [**ModelsConfigForm**](ModelsConfigForm.md) |  |  |

### Return type

[**ModelsConfigForm**](ModelsConfigForm.md)

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

<a id="settoolserversconfigapiv1configstoolserverspost"></a>
# **SetToolServersConfigApiV1ConfigsToolServersPost**
> ToolServersConfigForm SetToolServersConfigApiV1ConfigsToolServersPost (ToolServersConfigForm toolServersConfigForm)

Set Tool Servers Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolServersConfigForm** | [**ToolServersConfigForm**](ToolServersConfigForm.md) |  |  |

### Return type

[**ToolServersConfigForm**](ToolServersConfigForm.md)

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

<a id="verifytoolserversconfigapiv1configstoolserversverifypost"></a>
# **VerifyToolServersConfigApiV1ConfigsToolServersVerifyPost**
> Object VerifyToolServersConfigApiV1ConfigsToolServersVerifyPost (ToolServerConnection toolServerConnection)

Verify Tool Servers Config

Verify the connection to the tool server.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolServerConnection** | [**ToolServerConnection**](ToolServerConnection.md) |  |  |

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

