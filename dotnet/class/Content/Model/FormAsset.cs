using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Form asset.
	/// 
	/// percFormAsset
	/// {"asset":{"createDate":"2012-05-10T22:12:45.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"formuniquenamevalidator","value":null},{"name":"formdata","value":"{\"config\":{\"name\":\"test-forms-asset-export\",\"title\":\"test-forms-asset-export\",\"description\":\"\",\"processorType\":\"LocalServer\",\"processorURL\":\"\",\"successURL\":\"\",\"unencryptedSuccessURL\":\"\",\"encryptedSuccessURL\":\"\",\"errorURL\":\"\",\"unencryptedErrorURL\":\"\",\"encryptedErrorURL\":\"\"},\"fields\":[{\"label\":\"Descriptive text can be added by selecting the edit icon in the upper right.\",\"type\":\"PercTextFieldControl\"},{\"label\":\"Entry field label\",\"defaultValue\":\"Default text can be added to any text box.\",\"type\":\"PercEntryFieldControl\"},{\"label\":\"Submit\",\"type\":\"PercSubmitButtonControl\"},{\"label\":\"<p>Text<\/p>\",\"type\":\"PercTextFieldControl\"},{\"label\":\"Date field label\",\"defaultValue\":\"\",\"type\":\"PercDateControl\"}]}"},{"name":"formtitle","value":"test-forms-asset-export"},{"name":"description","value":null},{"name":"renderedform","value":"<script id='form-script' type='text\/javascript'>jQuery(document).ready(function(){jQuery('#test-forms-asset-export').validate()});<\/script><form name=\"test-forms-asset-export\" method=\"post\" action=\"\/perc-form-processor\/form\/\"><span class=\"form-title\">test-forms-asset-export<\/span><input value=\"test-forms-asset-export\" name=\"perc_formName\" type=\"hidden\" \/><input value=\"true\" name=\"perc_urlEncrypt\" type=\"hidden\" \/><input value=\"\" name=\"perc_successUrl\" type=\"hidden\" \/><input value=\"\" name=\"perc_errorUrl\" type=\"hidden\" \/><div id=\"field-descriptive-text-can-be-added-by-selecting-the-edit-icon-in-the-upper-right-label-container\" class=\"field-row\"><span>Descriptive text can be added by selecting the edit icon in the upper right.<\/span><\/div><div class=\"field-row\"><div id=\"field-entry-field-label-label-container\" class=\"field-label-container\"><label for=\"field-entry-field-label-input-container\">Entry field label<\/label><\/div><div id=\"field-entry-field-label-input-container\" class=\"field-input-container\"><input value=\"Default text can be added to any text box.\" name=\"entry-field-label\" type=\"text\" \/><\/div><\/div><div class=\"field-row\"><input value=\"Submit\" type=\"submit\" \/><\/div><div id=\"field-ptextp-label-container\" class=\"field-row\"><span><p>Text<\/p><\/span><\/div><div class=\"field-row\"><div id=\"field-date-field-label-label-container\" class=\"field-label-container\"><label for=\"date-field-label\">Date field label<\/label><\/div><div id=\"field-date-field-label-input-container\" class=\"field-input-container\"><input value=\"\" readonly=\"readonly\" name=\"date-field-label\" class=\"form-datepicker\" type=\"text\" \/><\/div><\/div><\/form>"}]},"id":"16777215-101-327","language":"en-us","lastModifiedDate":"2012-05-10T22:13:09.000-04:00","lastModifier":"Admin","name":"test-forms-asset-export","path":"\/Assets\/uploads\/test-forms-asset-export","publishDate":null,"revision":"1","type":"percFormAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:36.162-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class FormAsset : BaseAssetType
	{
		public FormAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

