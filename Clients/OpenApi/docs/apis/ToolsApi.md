# Org.OpenAPITools.Api.ToolsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewToolsApiV1ToolsCreatePost**](ToolsApi.md#createnewtoolsapiv1toolscreatepost) | **POST** /api/v1/tools/create | Create New Tools |
| [**DeleteToolsByIdApiV1ToolsIdIdDeleteDelete**](ToolsApi.md#deletetoolsbyidapiv1toolsididdeletedelete) | **DELETE** /api/v1/tools/id/{id}/delete | Delete Tools By Id |
| [**ExportToolsApiV1ToolsExportGet**](ToolsApi.md#exporttoolsapiv1toolsexportget) | **GET** /api/v1/tools/export | Export Tools |
| [**GetToolListApiV1ToolsListGet**](ToolsApi.md#gettoollistapiv1toolslistget) | **GET** /api/v1/tools/list | Get Tool List |
| [**GetToolsApiV1ToolsGet**](ToolsApi.md#gettoolsapiv1toolsget) | **GET** /api/v1/tools/ | Get Tools |
| [**GetToolsByIdApiV1ToolsIdIdGet**](ToolsApi.md#gettoolsbyidapiv1toolsididget) | **GET** /api/v1/tools/id/{id} | Get Tools By Id |
| [**GetToolsUserValvesByIdApiV1ToolsIdIdValvesUserGet**](ToolsApi.md#gettoolsuservalvesbyidapiv1toolsididvalvesuserget) | **GET** /api/v1/tools/id/{id}/valves/user | Get Tools User Valves By Id |
| [**GetToolsUserValvesSpecByIdApiV1ToolsIdIdValvesUserSpecGet**](ToolsApi.md#gettoolsuservalvesspecbyidapiv1toolsididvalvesuserspecget) | **GET** /api/v1/tools/id/{id}/valves/user/spec | Get Tools User Valves Spec By Id |
| [**GetToolsValvesByIdApiV1ToolsIdIdValvesGet**](ToolsApi.md#gettoolsvalvesbyidapiv1toolsididvalvesget) | **GET** /api/v1/tools/id/{id}/valves | Get Tools Valves By Id |
| [**GetToolsValvesSpecByIdApiV1ToolsIdIdValvesSpecGet**](ToolsApi.md#gettoolsvalvesspecbyidapiv1toolsididvalvesspecget) | **GET** /api/v1/tools/id/{id}/valves/spec | Get Tools Valves Spec By Id |
| [**LoadToolFromUrlApiV1ToolsLoadUrlPost**](ToolsApi.md#loadtoolfromurlapiv1toolsloadurlpost) | **POST** /api/v1/tools/load/url | Load Tool From Url |
| [**UpdateToolsByIdApiV1ToolsIdIdUpdatePost**](ToolsApi.md#updatetoolsbyidapiv1toolsididupdatepost) | **POST** /api/v1/tools/id/{id}/update | Update Tools By Id |
| [**UpdateToolsUserValvesByIdApiV1ToolsIdIdValvesUserUpdatePost**](ToolsApi.md#updatetoolsuservalvesbyidapiv1toolsididvalvesuserupdatepost) | **POST** /api/v1/tools/id/{id}/valves/user/update | Update Tools User Valves By Id |
| [**UpdateToolsValvesByIdApiV1ToolsIdIdValvesUpdatePost**](ToolsApi.md#updatetoolsvalvesbyidapiv1toolsididvalvesupdatepost) | **POST** /api/v1/tools/id/{id}/valves/update | Update Tools Valves By Id |

<a id="createnewtoolsapiv1toolscreatepost"></a>
# **CreateNewToolsApiV1ToolsCreatePost**
> ToolResponse CreateNewToolsApiV1ToolsCreatePost (ToolForm toolForm)

Create New Tools


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolForm** | [**ToolForm**](ToolForm.md) |  |  |

### Return type

[**ToolResponse**](ToolResponse.md)

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

<a id="deletetoolsbyidapiv1toolsididdeletedelete"></a>
# **DeleteToolsByIdApiV1ToolsIdIdDeleteDelete**
> bool DeleteToolsByIdApiV1ToolsIdIdDeleteDelete (string id)

Delete Tools By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a id="exporttoolsapiv1toolsexportget"></a>
# **ExportToolsApiV1ToolsExportGet**
> List&lt;ToolModel&gt; ExportToolsApiV1ToolsExportGet ()

Export Tools


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ToolModel&gt;**](ToolModel.md)

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

<a id="gettoollistapiv1toolslistget"></a>
# **GetToolListApiV1ToolsListGet**
> List&lt;ToolUserResponse&gt; GetToolListApiV1ToolsListGet ()

Get Tool List


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ToolUserResponse&gt;**](ToolUserResponse.md)

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

<a id="gettoolsapiv1toolsget"></a>
# **GetToolsApiV1ToolsGet**
> List&lt;ToolUserResponse&gt; GetToolsApiV1ToolsGet ()

Get Tools


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ToolUserResponse&gt;**](ToolUserResponse.md)

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

<a id="gettoolsbyidapiv1toolsididget"></a>
# **GetToolsByIdApiV1ToolsIdIdGet**
> ToolModel GetToolsByIdApiV1ToolsIdIdGet (string id)

Get Tools By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ToolModel**](ToolModel.md)

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

<a id="gettoolsuservalvesbyidapiv1toolsididvalvesuserget"></a>
# **GetToolsUserValvesByIdApiV1ToolsIdIdValvesUserGet**
> Object GetToolsUserValvesByIdApiV1ToolsIdIdValvesUserGet (string id)

Get Tools User Valves By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a id="gettoolsuservalvesspecbyidapiv1toolsididvalvesuserspecget"></a>
# **GetToolsUserValvesSpecByIdApiV1ToolsIdIdValvesUserSpecGet**
> Object GetToolsUserValvesSpecByIdApiV1ToolsIdIdValvesUserSpecGet (string id)

Get Tools User Valves Spec By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a id="gettoolsvalvesbyidapiv1toolsididvalvesget"></a>
# **GetToolsValvesByIdApiV1ToolsIdIdValvesGet**
> Object GetToolsValvesByIdApiV1ToolsIdIdValvesGet (string id)

Get Tools Valves By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a id="gettoolsvalvesspecbyidapiv1toolsididvalvesspecget"></a>
# **GetToolsValvesSpecByIdApiV1ToolsIdIdValvesSpecGet**
> Object GetToolsValvesSpecByIdApiV1ToolsIdIdValvesSpecGet (string id)

Get Tools Valves Spec By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a id="loadtoolfromurlapiv1toolsloadurlpost"></a>
# **LoadToolFromUrlApiV1ToolsLoadUrlPost**
> Object LoadToolFromUrlApiV1ToolsLoadUrlPost (LoadUrlForm loadUrlForm)

Load Tool From Url


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loadUrlForm** | [**LoadUrlForm**](LoadUrlForm.md) |  |  |

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

<a id="updatetoolsbyidapiv1toolsididupdatepost"></a>
# **UpdateToolsByIdApiV1ToolsIdIdUpdatePost**
> ToolModel UpdateToolsByIdApiV1ToolsIdIdUpdatePost (string id, ToolForm toolForm)

Update Tools By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **toolForm** | [**ToolForm**](ToolForm.md) |  |  |

### Return type

[**ToolModel**](ToolModel.md)

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

<a id="updatetoolsuservalvesbyidapiv1toolsididvalvesuserupdatepost"></a>
# **UpdateToolsUserValvesByIdApiV1ToolsIdIdValvesUserUpdatePost**
> Object UpdateToolsUserValvesByIdApiV1ToolsIdIdValvesUserUpdatePost (string id, Object body)

Update Tools User Valves By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
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

<a id="updatetoolsvalvesbyidapiv1toolsididvalvesupdatepost"></a>
# **UpdateToolsValvesByIdApiV1ToolsIdIdValvesUpdatePost**
> Object UpdateToolsValvesByIdApiV1ToolsIdIdValvesUpdatePost (string id, Object body)

Update Tools Valves By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
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

