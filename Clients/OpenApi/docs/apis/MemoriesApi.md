# Org.OpenAPITools.Api.MemoriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMemoryApiV1MemoriesAddPost**](MemoriesApi.md#addmemoryapiv1memoriesaddpost) | **POST** /api/v1/memories/add | Add Memory |
| [**DeleteMemoryByIdApiV1MemoriesMemoryIdDelete**](MemoriesApi.md#deletememorybyidapiv1memoriesmemoryiddelete) | **DELETE** /api/v1/memories/{memory_id} | Delete Memory By Id |
| [**DeleteMemoryByUserIdApiV1MemoriesDeleteUserDelete**](MemoriesApi.md#deletememorybyuseridapiv1memoriesdeleteuserdelete) | **DELETE** /api/v1/memories/delete/user | Delete Memory By User Id |
| [**GetEmbeddingsApiV1MemoriesEfGet**](MemoriesApi.md#getembeddingsapiv1memoriesefget) | **GET** /api/v1/memories/ef | Get Embeddings |
| [**GetMemoriesApiV1MemoriesGet**](MemoriesApi.md#getmemoriesapiv1memoriesget) | **GET** /api/v1/memories/ | Get Memories |
| [**QueryMemoryApiV1MemoriesQueryPost**](MemoriesApi.md#querymemoryapiv1memoriesquerypost) | **POST** /api/v1/memories/query | Query Memory |
| [**ResetMemoryFromVectorDbApiV1MemoriesResetPost**](MemoriesApi.md#resetmemoryfromvectordbapiv1memoriesresetpost) | **POST** /api/v1/memories/reset | Reset Memory From Vector Db |
| [**UpdateMemoryByIdApiV1MemoriesMemoryIdUpdatePost**](MemoriesApi.md#updatememorybyidapiv1memoriesmemoryidupdatepost) | **POST** /api/v1/memories/{memory_id}/update | Update Memory By Id |

<a id="addmemoryapiv1memoriesaddpost"></a>
# **AddMemoryApiV1MemoriesAddPost**
> MemoryModel AddMemoryApiV1MemoriesAddPost (AddMemoryForm addMemoryForm)

Add Memory


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addMemoryForm** | [**AddMemoryForm**](AddMemoryForm.md) |  |  |

### Return type

[**MemoryModel**](MemoryModel.md)

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

<a id="deletememorybyidapiv1memoriesmemoryiddelete"></a>
# **DeleteMemoryByIdApiV1MemoriesMemoryIdDelete**
> bool DeleteMemoryByIdApiV1MemoriesMemoryIdDelete (string memoryId)

Delete Memory By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memoryId** | **string** |  |  |

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

<a id="deletememorybyuseridapiv1memoriesdeleteuserdelete"></a>
# **DeleteMemoryByUserIdApiV1MemoriesDeleteUserDelete**
> bool DeleteMemoryByUserIdApiV1MemoriesDeleteUserDelete ()

Delete Memory By User Id


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

<a id="getembeddingsapiv1memoriesefget"></a>
# **GetEmbeddingsApiV1MemoriesEfGet**
> Object GetEmbeddingsApiV1MemoriesEfGet ()

Get Embeddings


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

<a id="getmemoriesapiv1memoriesget"></a>
# **GetMemoriesApiV1MemoriesGet**
> List&lt;MemoryModel&gt; GetMemoriesApiV1MemoriesGet ()

Get Memories


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;MemoryModel&gt;**](MemoryModel.md)

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

<a id="querymemoryapiv1memoriesquerypost"></a>
# **QueryMemoryApiV1MemoriesQueryPost**
> Object QueryMemoryApiV1MemoriesQueryPost (QueryMemoryForm queryMemoryForm)

Query Memory


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryMemoryForm** | [**QueryMemoryForm**](QueryMemoryForm.md) |  |  |

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

<a id="resetmemoryfromvectordbapiv1memoriesresetpost"></a>
# **ResetMemoryFromVectorDbApiV1MemoriesResetPost**
> bool ResetMemoryFromVectorDbApiV1MemoriesResetPost ()

Reset Memory From Vector Db


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

<a id="updatememorybyidapiv1memoriesmemoryidupdatepost"></a>
# **UpdateMemoryByIdApiV1MemoriesMemoryIdUpdatePost**
> MemoryModel UpdateMemoryByIdApiV1MemoriesMemoryIdUpdatePost (string memoryId, MemoryUpdateModel memoryUpdateModel)

Update Memory By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memoryId** | **string** |  |  |
| **memoryUpdateModel** | [**MemoryUpdateModel**](MemoryUpdateModel.md) |  |  |

### Return type

[**MemoryModel**](MemoryModel.md)

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

