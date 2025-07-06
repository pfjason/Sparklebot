# Org.OpenAPITools.Api.ImagesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetConfigApiV1ImagesConfigGet**](ImagesApi.md#getconfigapiv1imagesconfigget) | **GET** /api/v1/images/config | Get Config |
| [**GetImageConfigApiV1ImagesImageConfigGet**](ImagesApi.md#getimageconfigapiv1imagesimageconfigget) | **GET** /api/v1/images/image/config | Get Image Config |
| [**GetModelsApiV1ImagesModelsGet**](ImagesApi.md#getmodelsapiv1imagesmodelsget) | **GET** /api/v1/images/models | Get Models |
| [**ImageGenerationsApiV1ImagesGenerationsPost**](ImagesApi.md#imagegenerationsapiv1imagesgenerationspost) | **POST** /api/v1/images/generations | Image Generations |
| [**UpdateConfigApiV1ImagesConfigUpdatePost**](ImagesApi.md#updateconfigapiv1imagesconfigupdatepost) | **POST** /api/v1/images/config/update | Update Config |
| [**UpdateImageConfigApiV1ImagesImageConfigUpdatePost**](ImagesApi.md#updateimageconfigapiv1imagesimageconfigupdatepost) | **POST** /api/v1/images/image/config/update | Update Image Config |
| [**VerifyUrlApiV1ImagesConfigUrlVerifyGet**](ImagesApi.md#verifyurlapiv1imagesconfigurlverifyget) | **GET** /api/v1/images/config/url/verify | Verify Url |

<a id="getconfigapiv1imagesconfigget"></a>
# **GetConfigApiV1ImagesConfigGet**
> Object GetConfigApiV1ImagesConfigGet ()

Get Config


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

<a id="getimageconfigapiv1imagesimageconfigget"></a>
# **GetImageConfigApiV1ImagesImageConfigGet**
> Object GetImageConfigApiV1ImagesImageConfigGet ()

Get Image Config


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

<a id="getmodelsapiv1imagesmodelsget"></a>
# **GetModelsApiV1ImagesModelsGet**
> Object GetModelsApiV1ImagesModelsGet ()

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

<a id="imagegenerationsapiv1imagesgenerationspost"></a>
# **ImageGenerationsApiV1ImagesGenerationsPost**
> Object ImageGenerationsApiV1ImagesGenerationsPost (GenerateImageForm generateImageForm)

Image Generations


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generateImageForm** | [**GenerateImageForm**](GenerateImageForm.md) |  |  |

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

<a id="updateconfigapiv1imagesconfigupdatepost"></a>
# **UpdateConfigApiV1ImagesConfigUpdatePost**
> Object UpdateConfigApiV1ImagesConfigUpdatePost (OpenWebuiRoutersImagesConfigForm openWebuiRoutersImagesConfigForm)

Update Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **openWebuiRoutersImagesConfigForm** | [**OpenWebuiRoutersImagesConfigForm**](OpenWebuiRoutersImagesConfigForm.md) |  |  |

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

<a id="updateimageconfigapiv1imagesimageconfigupdatepost"></a>
# **UpdateImageConfigApiV1ImagesImageConfigUpdatePost**
> Object UpdateImageConfigApiV1ImagesImageConfigUpdatePost (ImageConfigForm imageConfigForm)

Update Image Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imageConfigForm** | [**ImageConfigForm**](ImageConfigForm.md) |  |  |

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

<a id="verifyurlapiv1imagesconfigurlverifyget"></a>
# **VerifyUrlApiV1ImagesConfigUrlVerifyGet**
> Object VerifyUrlApiV1ImagesConfigUrlVerifyGet ()

Verify Url


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

