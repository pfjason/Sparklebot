# Org.OpenAPITools.Api.RetrievalApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteEntriesFromCollectionApiV1RetrievalDeletePost**](RetrievalApi.md#deleteentriesfromcollectionapiv1retrievaldeletepost) | **POST** /api/v1/retrieval/delete | Delete Entries From Collection |
| [**GetEmbeddingConfigApiV1RetrievalEmbeddingGet**](RetrievalApi.md#getembeddingconfigapiv1retrievalembeddingget) | **GET** /api/v1/retrieval/embedding | Get Embedding Config |
| [**GetEmbeddingsApiV1RetrievalEfTextGet**](RetrievalApi.md#getembeddingsapiv1retrievaleftextget) | **GET** /api/v1/retrieval/ef/{text} | Get Embeddings |
| [**GetRagConfigApiV1RetrievalConfigGet**](RetrievalApi.md#getragconfigapiv1retrievalconfigget) | **GET** /api/v1/retrieval/config | Get Rag Config |
| [**GetStatusApiV1RetrievalGet**](RetrievalApi.md#getstatusapiv1retrievalget) | **GET** /api/v1/retrieval/ | Get Status |
| [**ProcessFileApiV1RetrievalProcessFilePost**](RetrievalApi.md#processfileapiv1retrievalprocessfilepost) | **POST** /api/v1/retrieval/process/file | Process File |
| [**ProcessFilesBatchApiV1RetrievalProcessFilesBatchPost**](RetrievalApi.md#processfilesbatchapiv1retrievalprocessfilesbatchpost) | **POST** /api/v1/retrieval/process/files/batch | Process Files Batch |
| [**ProcessTextApiV1RetrievalProcessTextPost**](RetrievalApi.md#processtextapiv1retrievalprocesstextpost) | **POST** /api/v1/retrieval/process/text | Process Text |
| [**ProcessWebApiV1RetrievalProcessWebPost**](RetrievalApi.md#processwebapiv1retrievalprocesswebpost) | **POST** /api/v1/retrieval/process/web | Process Web |
| [**ProcessWebSearchApiV1RetrievalProcessWebSearchPost**](RetrievalApi.md#processwebsearchapiv1retrievalprocesswebsearchpost) | **POST** /api/v1/retrieval/process/web/search | Process Web Search |
| [**ProcessYoutubeVideoApiV1RetrievalProcessYoutubePost**](RetrievalApi.md#processyoutubevideoapiv1retrievalprocessyoutubepost) | **POST** /api/v1/retrieval/process/youtube | Process Youtube Video |
| [**QueryCollectionHandlerApiV1RetrievalQueryCollectionPost**](RetrievalApi.md#querycollectionhandlerapiv1retrievalquerycollectionpost) | **POST** /api/v1/retrieval/query/collection | Query Collection Handler |
| [**QueryDocHandlerApiV1RetrievalQueryDocPost**](RetrievalApi.md#querydochandlerapiv1retrievalquerydocpost) | **POST** /api/v1/retrieval/query/doc | Query Doc Handler |
| [**ResetUploadDirApiV1RetrievalResetUploadsPost**](RetrievalApi.md#resetuploaddirapiv1retrievalresetuploadspost) | **POST** /api/v1/retrieval/reset/uploads | Reset Upload Dir |
| [**ResetVectorDbApiV1RetrievalResetDbPost**](RetrievalApi.md#resetvectordbapiv1retrievalresetdbpost) | **POST** /api/v1/retrieval/reset/db | Reset Vector Db |
| [**UpdateEmbeddingConfigApiV1RetrievalEmbeddingUpdatePost**](RetrievalApi.md#updateembeddingconfigapiv1retrievalembeddingupdatepost) | **POST** /api/v1/retrieval/embedding/update | Update Embedding Config |
| [**UpdateRagConfigApiV1RetrievalConfigUpdatePost**](RetrievalApi.md#updateragconfigapiv1retrievalconfigupdatepost) | **POST** /api/v1/retrieval/config/update | Update Rag Config |

<a id="deleteentriesfromcollectionapiv1retrievaldeletepost"></a>
# **DeleteEntriesFromCollectionApiV1RetrievalDeletePost**
> Object DeleteEntriesFromCollectionApiV1RetrievalDeletePost (DeleteForm deleteForm)

Delete Entries From Collection


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteForm** | [**DeleteForm**](DeleteForm.md) |  |  |

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

<a id="getembeddingconfigapiv1retrievalembeddingget"></a>
# **GetEmbeddingConfigApiV1RetrievalEmbeddingGet**
> Object GetEmbeddingConfigApiV1RetrievalEmbeddingGet ()

Get Embedding Config


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

<a id="getembeddingsapiv1retrievaleftextget"></a>
# **GetEmbeddingsApiV1RetrievalEfTextGet**
> Object GetEmbeddingsApiV1RetrievalEfTextGet (string text)

Get Embeddings


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **text** | **string** |  |  |

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

<a id="getragconfigapiv1retrievalconfigget"></a>
# **GetRagConfigApiV1RetrievalConfigGet**
> Object GetRagConfigApiV1RetrievalConfigGet ()

Get Rag Config


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

<a id="getstatusapiv1retrievalget"></a>
# **GetStatusApiV1RetrievalGet**
> Object GetStatusApiV1RetrievalGet ()

Get Status


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

<a id="processfileapiv1retrievalprocessfilepost"></a>
# **ProcessFileApiV1RetrievalProcessFilePost**
> Object ProcessFileApiV1RetrievalProcessFilePost (ProcessFileForm processFileForm)

Process File


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processFileForm** | [**ProcessFileForm**](ProcessFileForm.md) |  |  |

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

<a id="processfilesbatchapiv1retrievalprocessfilesbatchpost"></a>
# **ProcessFilesBatchApiV1RetrievalProcessFilesBatchPost**
> BatchProcessFilesResponse ProcessFilesBatchApiV1RetrievalProcessFilesBatchPost (BatchProcessFilesForm batchProcessFilesForm)

Process Files Batch

Process a batch of files and save them to the vector database.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchProcessFilesForm** | [**BatchProcessFilesForm**](BatchProcessFilesForm.md) |  |  |

### Return type

[**BatchProcessFilesResponse**](BatchProcessFilesResponse.md)

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

<a id="processtextapiv1retrievalprocesstextpost"></a>
# **ProcessTextApiV1RetrievalProcessTextPost**
> Object ProcessTextApiV1RetrievalProcessTextPost (ProcessTextForm processTextForm)

Process Text


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processTextForm** | [**ProcessTextForm**](ProcessTextForm.md) |  |  |

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

<a id="processwebapiv1retrievalprocesswebpost"></a>
# **ProcessWebApiV1RetrievalProcessWebPost**
> Object ProcessWebApiV1RetrievalProcessWebPost (ProcessUrlForm processUrlForm)

Process Web


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processUrlForm** | [**ProcessUrlForm**](ProcessUrlForm.md) |  |  |

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

<a id="processwebsearchapiv1retrievalprocesswebsearchpost"></a>
# **ProcessWebSearchApiV1RetrievalProcessWebSearchPost**
> Object ProcessWebSearchApiV1RetrievalProcessWebSearchPost (SearchForm searchForm)

Process Web Search


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchForm** | [**SearchForm**](SearchForm.md) |  |  |

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

<a id="processyoutubevideoapiv1retrievalprocessyoutubepost"></a>
# **ProcessYoutubeVideoApiV1RetrievalProcessYoutubePost**
> Object ProcessYoutubeVideoApiV1RetrievalProcessYoutubePost (ProcessUrlForm processUrlForm)

Process Youtube Video


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processUrlForm** | [**ProcessUrlForm**](ProcessUrlForm.md) |  |  |

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

<a id="querycollectionhandlerapiv1retrievalquerycollectionpost"></a>
# **QueryCollectionHandlerApiV1RetrievalQueryCollectionPost**
> Object QueryCollectionHandlerApiV1RetrievalQueryCollectionPost (QueryCollectionsForm queryCollectionsForm)

Query Collection Handler


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryCollectionsForm** | [**QueryCollectionsForm**](QueryCollectionsForm.md) |  |  |

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

<a id="querydochandlerapiv1retrievalquerydocpost"></a>
# **QueryDocHandlerApiV1RetrievalQueryDocPost**
> Object QueryDocHandlerApiV1RetrievalQueryDocPost (QueryDocForm queryDocForm)

Query Doc Handler


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryDocForm** | [**QueryDocForm**](QueryDocForm.md) |  |  |

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

<a id="resetuploaddirapiv1retrievalresetuploadspost"></a>
# **ResetUploadDirApiV1RetrievalResetUploadsPost**
> bool ResetUploadDirApiV1RetrievalResetUploadsPost ()

Reset Upload Dir


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

<a id="resetvectordbapiv1retrievalresetdbpost"></a>
# **ResetVectorDbApiV1RetrievalResetDbPost**
> Object ResetVectorDbApiV1RetrievalResetDbPost ()

Reset Vector Db


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

<a id="updateembeddingconfigapiv1retrievalembeddingupdatepost"></a>
# **UpdateEmbeddingConfigApiV1RetrievalEmbeddingUpdatePost**
> Object UpdateEmbeddingConfigApiV1RetrievalEmbeddingUpdatePost (EmbeddingModelUpdateForm embeddingModelUpdateForm)

Update Embedding Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **embeddingModelUpdateForm** | [**EmbeddingModelUpdateForm**](EmbeddingModelUpdateForm.md) |  |  |

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

<a id="updateragconfigapiv1retrievalconfigupdatepost"></a>
# **UpdateRagConfigApiV1RetrievalConfigUpdatePost**
> Object UpdateRagConfigApiV1RetrievalConfigUpdatePost (OpenWebuiRoutersRetrievalConfigForm openWebuiRoutersRetrievalConfigForm)

Update Rag Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **openWebuiRoutersRetrievalConfigForm** | [**OpenWebuiRoutersRetrievalConfigForm**](OpenWebuiRoutersRetrievalConfigForm.md) |  |  |

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

