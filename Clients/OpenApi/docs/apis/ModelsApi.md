# Org.OpenAPITools.Api.ModelsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewModelApiV1ModelsCreatePost**](ModelsApi.md#createnewmodelapiv1modelscreatepost) | **POST** /api/v1/models/create | Create New Model |
| [**DeleteAllModelsApiV1ModelsDeleteAllDelete**](ModelsApi.md#deleteallmodelsapiv1modelsdeletealldelete) | **DELETE** /api/v1/models/delete/all | Delete All Models |
| [**DeleteModelByIdApiV1ModelsModelDeleteDelete**](ModelsApi.md#deletemodelbyidapiv1modelsmodeldeletedelete) | **DELETE** /api/v1/models/model/delete | Delete Model By Id |
| [**GetBaseModelsApiV1ModelsBaseGet**](ModelsApi.md#getbasemodelsapiv1modelsbaseget) | **GET** /api/v1/models/base | Get Base Models |
| [**GetModelByIdApiV1ModelsModelGet**](ModelsApi.md#getmodelbyidapiv1modelsmodelget) | **GET** /api/v1/models/model | Get Model By Id |
| [**GetModelsApiV1ModelsGet**](ModelsApi.md#getmodelsapiv1modelsget) | **GET** /api/v1/models/ | Get Models |
| [**ToggleModelByIdApiV1ModelsModelTogglePost**](ModelsApi.md#togglemodelbyidapiv1modelsmodeltogglepost) | **POST** /api/v1/models/model/toggle | Toggle Model By Id |
| [**UpdateModelByIdApiV1ModelsModelUpdatePost**](ModelsApi.md#updatemodelbyidapiv1modelsmodelupdatepost) | **POST** /api/v1/models/model/update | Update Model By Id |

<a id="createnewmodelapiv1modelscreatepost"></a>
# **CreateNewModelApiV1ModelsCreatePost**
> ModelModel CreateNewModelApiV1ModelsCreatePost (ModelForm modelForm)

Create New Model


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelForm** | [**ModelForm**](ModelForm.md) |  |  |

### Return type

[**ModelModel**](ModelModel.md)

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

<a id="deleteallmodelsapiv1modelsdeletealldelete"></a>
# **DeleteAllModelsApiV1ModelsDeleteAllDelete**
> bool DeleteAllModelsApiV1ModelsDeleteAllDelete ()

Delete All Models


### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletemodelbyidapiv1modelsmodeldeletedelete"></a>
# **DeleteModelByIdApiV1ModelsModelDeleteDelete**
> bool DeleteModelByIdApiV1ModelsModelDeleteDelete (string id)

Delete Model By Id


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

<a id="getbasemodelsapiv1modelsbaseget"></a>
# **GetBaseModelsApiV1ModelsBaseGet**
> List&lt;ModelResponse&gt; GetBaseModelsApiV1ModelsBaseGet ()

Get Base Models


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ModelResponse&gt;**](ModelResponse.md)

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

<a id="getmodelbyidapiv1modelsmodelget"></a>
# **GetModelByIdApiV1ModelsModelGet**
> ModelResponse GetModelByIdApiV1ModelsModelGet (string id)

Get Model By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ModelResponse**](ModelResponse.md)

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

<a id="getmodelsapiv1modelsget"></a>
# **GetModelsApiV1ModelsGet**
> List&lt;ModelUserResponse&gt; GetModelsApiV1ModelsGet (string id = null)

Get Models


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  | [optional]  |

### Return type

[**List&lt;ModelUserResponse&gt;**](ModelUserResponse.md)

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

<a id="togglemodelbyidapiv1modelsmodeltogglepost"></a>
# **ToggleModelByIdApiV1ModelsModelTogglePost**
> ModelResponse ToggleModelByIdApiV1ModelsModelTogglePost (string id)

Toggle Model By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ModelResponse**](ModelResponse.md)

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

<a id="updatemodelbyidapiv1modelsmodelupdatepost"></a>
# **UpdateModelByIdApiV1ModelsModelUpdatePost**
> ModelModel UpdateModelByIdApiV1ModelsModelUpdatePost (string id, ModelForm modelForm)

Update Model By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **modelForm** | [**ModelForm**](ModelForm.md) |  |  |

### Return type

[**ModelModel**](ModelModel.md)

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

