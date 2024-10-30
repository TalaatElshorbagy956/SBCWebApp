var complaintClassifications;
var loadingCount = 0;

document.addEventListener('DOMContentLoaded', function () {

    // Initialize Select2
    $('#mainClassification').select2();
    $('#subClassification').select2();


    setLangDirectionOnLoad();


    //onscroll animation
    $(window).on('scroll resize', checkVisibility);
    // Initial check
    checkVisibility();

    const searchForm = document.querySelector('.form.searchComplaint');
    searchForm.addEventListener('submit', function (event) {
        event.preventDefault();
        const searchValue = document.getElementById('searchCaseInput').value;
        if (searchValue)
            //get the complaint data
            jqAjaxGet('Complaint/GetComplaintByNumber', { complaintNumber: searchValue, lang: getQueryParam('lang') || 'en' },
                function (complaint) {
                    if (complaint) {

                        FillFormWithData(complaint);

                    } else {
                        //$('#notFoundAlert').show();
                        showAlert('danger', 'ComplaintNotFound');
                    }
                }
            );


    });

    $('.complaintCreationBtn').on('click', PrepareFormForCreation);

    // Create Complaint
    document.querySelector('.form.complaintForm').addEventListener('submit', function (event) {

        event.preventDefault();
        $('#submitComplaintBtn').prop("disabled", true);
        const newComplaint = PrepareFormDataForCreation();

        jqAjaxPost('Complaint/CreateComplaint', newComplaint,
            function (data) {
                if (data) {
                    $('#complaintNumber').parent('.form-group').show();
                    $('#complaintNumber').val(data);
                    showAlert('success', 'ComplaintCreatedSuccessMsg');
                    //$('#complaintCreatedSuccessfullyAlert').show();
                }
                else {
                    //$('#complaintNotCreatedAlert').show();
                    showAlert('danger', 'ComplaintNotCreatedMsg');

                    $('#submitComplaintBtn').prop("disabled", true);
                }
            },
            function (e) {
                if (e.status == 400 || e.status == 404 || e.status == 401) {
                    //$('#complaintNotCreatedAlert').show();
                    showAlert('danger', 'ComplaintNotCreatedMsg');

                    $('#submitComplaintBtn').prop("disabled", true);
                }
                console.log(e);
            }
        );

    });



    const submitSearchCustomer = function () {
        const value = $("#customerName").val();
        if (value)
            GetCustomerDetails(value, function (data) {

                if (data && data.EndingDigitsOfPhoneNumber && data.Id) {

                    $('#phoneEndingDigits').text(data.EndingDigitsOfPhoneNumber);
                    $('#customerId').val(data.Id);
                    $('#FoundCustomerConfirmModal').modal('show');
                }
                else
                    showAlert('info', 'CustomerNotFound', 'CustomerNotFoundMsg');

            });
    }
    //on enter value search contact
    $(document).on('click', '#customerSearchBtn', submitSearchCustomer);
    $(document).on('keydown', '#customerName', function (e) {
        if (e.key === 'Enter') {
            e.preventDefault();
            submitSearchCustomer();
        }
    });


    PrepareFormForCreation(false/*no auto scroll*/);

    //ui events
    $('.close').on('click', function () {
        $(this).closest('.alert').hide();
    });

    //on unselect mainclass , clear subclass
    $('#mainClassification').on('select2:unselecting', function () {
        $('#subClassification').val('').prop('disabled', true).select2();
    });



    const OtpInputs = document.querySelectorAll('#otpInputsWarpper > div > input');
    const OtpInputsArray = Array.from(OtpInputs);

    const otpSubmitBtn = document.querySelector('#OTPSubmitBtn');

    const OtpInputHandleKeyDown = (e) => {
        if (
            !/^[0-9]{1}$/.test(e.key) &&
            e.key !== 'Backspace' &&
            e.key !== 'Delete' &&
            e.key !== 'Tab' &&
            !e.metaKey
        ) {
            e.preventDefault();
        }

        if (e.key === 'Delete' || e.key === 'Backspace') {
            const index = OtpInputsArray.indexOf(e.target);
            if (index > 0) {
                OtpInputsArray[index].value = '';
                OtpInputsArray[index - 1].focus();
            }
        }
    };

    const OtpInputHandleInput = (e) => {
        const { target } = e;
        const index = OtpInputsArray.indexOf(target);
        if (target.value) {
            if (index < OtpInputsArray.length - 1) {
                OtpInputsArray[index + 1].focus();
            } else {
                otpSubmitBtn.focus();
            }
        }
    };

    const OtpInputHandleFocus = (e) => {
        e.target.select();
    };

    const OtpInputHandlePaste = (e) => {
        e.preventDefault();
        const text = e.clipboardData.getData('text');
        if (!new RegExp(`^[0-9]{${OtpInputsArray.length}}$`).test(text)) {
            return;
        }
        const digits = text.split('');
        OtpInputsArray.forEach((input, index) => {
            input.value = digits[index];
        });
        otpSubmitBtn.focus();
    };

    // Attach event listeners using pure JavaScript
    OtpInputsArray.forEach(input => {
        input.addEventListener('input', OtpInputHandleInput);
        input.addEventListener('keydown', OtpInputHandleKeyDown);
        input.addEventListener('focus', OtpInputHandleFocus);
        input.addEventListener('paste', OtpInputHandlePaste);
    });



    //Create Customer Validations
    $('#CreateCustomerIdNumber').on('input', function (e) {
        validateIdNumber(e.target);
    });

    $('#CreateCustomerIdentityType').on('change', function (e) {
        $('#CreateCustomerIdNumber').val('');
    });

    function validateIdNumber(target) {
        const idNumber = $('#CreateCustomerIdNumber').val();
        const identityType = $('#CreateCustomerIdentityType').val();
        target.setCustomValidity(''); // Clear previous custom validity messages
        if (idNumber)
            switch (parseInt(identityType)) {
                case 1:
                case 2:
                    const validationResult = ValidateSAID.Check(idNumber);
                    if (validationResult !== parseInt(identityType)) {
                        if (parseInt(identityType) == 1) {
                            target.setCustomValidity('Invalid Saudi ID.');
                        } else if (parseInt(identityType) == 2) {
                            target.setCustomValidity('Invalid Resident ID.');
                        }
                    }
                    break;
                //case 3:
                //    if (!/^[A-PR-WY][1-9]\d\s?\d{4}[1-9]$/.test(idNumber)) {
                //        target.setCustomValidity('Invalid passport number.');
                //    }
                //    break;
               
            }
    }

    const ValidateSAID = {
        Check: function (id) {
            id = id.trim();
            if (!/^[0-9]+$/.test(id)) {
                return -1;
            }
            if (id.length !== 10) {
                return -1;
            }
            const type = parseInt(id[0], 10);
            if (type !== 2 && type !== 1) {
                return -1;
            }
            let sum = 0;
            for (let i = 0; i < 10; i++) {
                if (i % 2 === 0) {
                    const ZFOdd = (parseInt(id[i], 10) * 2).toString().padStart(2, '0');
                    sum += parseInt(ZFOdd[0], 10) + parseInt(ZFOdd[1], 10);
                } else {
                    sum += parseInt(id[i], 10);
                }
            }
            return (sum % 10 !== 0) ? -1 : type;
        }
    };

    //end of Create Customer Validation


    $('#CreateCustomerForm').on('submit', function (e) {
        e.preventDefault();
        ;
        //check otpToken
        var otpToken = $('#CreateCustomerOtpToken').val();
        if (otpToken) {
            var formDataArray = $(e.target).serializeArray();
            var formData = formDataArray.reduce(function (obj, item) {
                obj[item.name] = item.value;
                return obj;
            }, {});

            //submit customer
            jqAjaxPost("Customer/CreateCustomer", formData, function (createdId) {
                //Fill Customer data on main complaint form
                ;
                formData.Id = createdId;
                FillCustomerDetails(formData, otpToken);
                //reset form
                $('#CreateCustomerForm').get(0).reset();
                $('#CreateNewCustomerModal').modal('hide');
            }, function (e) {
                if (e.status == 400 && e.responseJSON.Message == "CustomerNotCreated") {
                    //$('#CustomerNotCreatedAlert').show();
                    showAlert('danger', 'CustomerNotCreated');

                }
            })
        }
        else {
            e.preventDefault();
            var phoneNumber = $('#CreateCustomerPhone').val();
            //call otp generate and send
            jqAjaxPost("Auth/GeneratePhoneOTP", { PhoneNumber: phoneNumber }, function () {
                //open otp form

                $('#OTPModal').modal('show');
                //set some data for later submit otp
                $('#OTPModal').data('submit-data', { PhoneNumber: phoneNumber });
                $('#OTPModal').data('otp-submit-api', "Auth/SubmitSentOTP");
                $('#OTPModal').data('otp-resend-api', "Auth/GeneratePhoneOTP");
            },
                function (e) {
                    if (e.status == 400 && e.responseJSON.Message == "SMSSendingFailed") {
                        //alert("Verification Code Not Sent! please try again later.")
                        showAlert('danger', 'OTPSendingError');
                    } else
                        console.error(e);

                })
        }
    });


    $('#OTPResendBtn').on('click', function (e) {
        e.preventDefault();

        //get some data for resend
        let data = $('#OTPModal').data('submit-data');
        let otpResendAPI = $('#OTPModal').data('otp-resend-api');
        //call otp generate and send
        jqAjaxPost(otpResendAPI, data, function () {
            ShowQuickMessage("#OTPFormMessage", "Verification Code resent!", "blue");
        },
            function (e) {
                if (e.status == 400 && e.responseJSON.Message == "SMSSendingFailed") {
                    //alert("Verification Code Not Sent! please try again later.")
                    showAlert('danger', 'OTPSendingError');

                } else
                    console.error(e);

            })
    })

    $('#OtpForm').on('submit', function (e) {
        e.preventDefault();

        //reset otp token
        $('#CreateCustomerOtpToken').val('');
        $('#CreateComplaintOtpToken').val('');
        //set some data for later submit otp
        let data = $('#OTPModal').data('submit-data');
        let otpSubmitAPI = $('#OTPModal').data('otp-submit-api');
        data.OTPCode = '';
        $('#otpInputsWarpper > div > input').each(function () {
            data["OTPCode"] += $(this).val();
            $(this).val('');//reset
        });
        if (!data.OTPCode) {
            ShowQuickMessage("#OTPFormMessage", "Please enter the full verification code!", "red");
            return;
        }
        //call otp verification api
        jqAjaxPost(otpSubmitAPI, data, function (result) {

            if (!result) {
                showAlert('danger', 'SomethingGoesWrong');

                return;
            }
            //success dismiss
            $('#OTPModal').modal('hide');

            if ($('#OTPModal').data('otp-submit-api') == "Customer/SubmitSentOTPToGetCustomer") {
                //directly fill customer details
                FillCustomerDetails(result.Customer, result.OTPToken);

            } else if ($('#OTPModal').data('otp-submit-api') == "Auth/SubmitSentOTP") {

                $('#CreateCustomerOtpToken').val(result.OTPToken);

                //now Create the new customer
                $('#CreateCustomerForm').submit();
            }

        }, function (e) {
            //failed => show message
            if (e.status == 400 && e?.responseJSON?.Message == "InvalidOTP") {
                ShowQuickMessage("#OTPFormMessage", "Wrong verification code! try again..", "red");
            }
        })

    });



    //send otp generation for get customer 
    $('#confirmFoundCustomerSendOtpBtn').on('click', function () {

        var CustomerId = $('#customerId').val();
        //call otp generate and send
        jqAjaxPost("Customer/GenerateOTPByCustomerId", { CustomerId }, function () {
            $('#FoundCustomerConfirmModal').modal('hide');
            //show otp modal to enter and submit otp
            $('#OTPModal').modal('show');
            //set some data for later submit otp
            $('#OTPModal').data('submit-data', { CustomerId });
            $('#OTPModal').data('otp-submit-api', "Customer/SubmitSentOTPToGetCustomer");
            $('#OTPModal').data('otp-resend-api', "Customer/GenerateOTPByCustomerId");
        },
            function (e) {
                if (e.status == 400 && e.responseJSON.Message == "SMSSendingFailed") {
                    //alert("Verification Code Not Sent! please try again later.");
                    showAlert('danger', 'OTPSendingError');
                } else
                    console.error(e);

            }
        )
    })



});
//end of onLoad doc
///////////////////////////////////////////////////////////////////
function FillCustomerDetails(_contactDetails, otpToken) {

    if (_contactDetails) {
        $('#CreateComplaintOtpToken').val(otpToken);
        $('#customerId').val(_contactDetails.Id);
        $('#customerName').val(_contactDetails.FullName);
        $('#idNumber').val(_contactDetails.IdNumber);
        $('#phoneNumber').val(_contactDetails.PhoneNumber);
        $('#emailAddress').val(_contactDetails.Email);
    } else {
        $('#CreateComplaintOtpToken').val('');
        $('#customerId').empty();
        $('#customerName').empty();
        $('#idNumber').empty();
        $('#phoneNumber').empty();
        $('#emailAddress').empty();
    }
}
function FillFormWithData(data) {

    $('#status').parent('.form-group').show();
    $('#complaintNumber').parent('.form-group').show();
    document.getElementById('complaintNumber').value = data.ComplaintNumber;
    var stateName = StateCode.find(x => x.id == data.Statecode)
    document.getElementById('status').value = stateName?.Text ?? data.Status;
    $('#idNumber').parent('.form-group').hide();
    $('#phoneNumber').parent('.form-group').hide();
    $('#emailAddress').parent('.form-group').hide();

    document.getElementById('complaintDescription').value = data.ComplaintDescription;

    $('.customerNewBtn-wrapper').hide();
    FillCustomerDetails(data.Contact, '');

    $('#mainClassification').off('change');
    PopulateSelectElement("mainClassification", [data.MainClassification], true);
    PopulateSelectElement("subClassification", [data.SubClassification], true);

    $('html, body').animate({
        scrollTop: $('.complaintForm').offset().top
    }, 500);

    $('.complaintForm').find('input, select, textarea, button').prop('disabled', true);
}

function PrepareFormDataForCreation() {
    const newComplaint = {
        CustomerId: document.getElementById('customerId').value,
        IdNumber: document.getElementById('idNumber').value,
        PhoneNumber: document.getElementById('phoneNumber').value,
        EmailAddress: document.getElementById('emailAddress').value,
        ComplaintDescription: document.getElementById('complaintDescription').value,
        MainClassification: document.getElementById('mainClassification').value,
        SubClassification: document.getElementById('subClassification').value,
        OTPToken: $('#CreateComplaintOtpToken').val()
    };

    return newComplaint;
}

function PrepareFormForCreation(animate = true) {

    $('#submitComplaintBtn').prop("disabled", false);
    if (animate)
        $('html, body').animate({
            scrollTop: $('.complaintForm').offset().top
        }, 500);

    $('form.complaintForm')[0].reset();
    $('#status').parent('.form-group').hide();
    $('#complaintNumber').parent('.form-group').hide();
    $('#idNumber').parent('.form-group').show();
    $('#phoneNumber').parent('.form-group').show();
    $('#emailAddress').parent('.form-group').show();
    $("#customerName").prop('disabled', false);
    $('.customerNewBtn-wrapper').show();
    $("#customerNewBtn").prop('disabled', false);
    $("#customerSearchBtn").prop('disabled', false);
    FillCustomerDetails();//no param to reset
    $("#complaintDescription").prop('disabled', false);
    $("#mainClassification").prop('disabled', false);
    $('#mainClassification').empty();
    $("#subClassification").prop('disabled', false);
    $('#subClassification').empty();

    //optimize performance by caching classifications tree for one session
    if (!complaintClassifications || complaintClassifications.length == 0) {
        GetMainOrSubClassSBCData("Complaint/GetMainClassificationsForSBC", null, function (sbcMainClassItems) {
            complaintClassifications = sbcMainClassItems;
            PopulateSelectElement("mainClassification", sbcMainClassItems);
        });
    } else {
        PopulateSelectElement("mainClassification", complaintClassifications);
    }

    $('#mainClassification').on('change', function () {
        const selectedMainClassValue = $(this).val();
        //init
        $('#subClassification').prop('disabled', false);
        if (complaintClassifications && complaintClassifications.length > 0) {
            var found = complaintClassifications.filter(a => a.Id == selectedMainClassValue);
            if (found && found.length > 0)
                PopulateSelectElement("subClassification", found[0].SubClassifications);
        }

    });


}

function GetMainOrSubClassSBCData(endpoint, param, callback) {
    jqAjaxGet(endpoint, param ? { parentClassId: param } : null,
        function (data) {
            if (data && data?.length > 0) {
                callback(data);
            }
            return null;
        })
}

function GetCustomerDetails(value, callback) {
    jqAjaxGet("Customer/GetCustomerByQuery", { query2: value },
        function (data) {
            if (data) {
                callback(data);
            }
            return null;
        });
}


//helper methods
function PopulateSelectElement(selectElementId, items, isOneSelected = false) {
    $('#' + selectElementId).empty();
    if (items && items.length > 0)
        items.forEach(item => {
            $('#' + selectElementId).append(new Option(item.Name, item.Id, isOneSelected));
        });
    $('#' + selectElementId).select2();
    $('#' + selectElementId).trigger('change');
}

function jqAjaxGet(endpoint, params, successCallback, errorCallback) {
    $('.lds-ripple-wrapper').show();
    loadingCount++;

    var authToken = getQueryParam('authToken');
    $.ajax({
        url: window.location.origin + (isProduction ? "/SBCCase" : "") + "/api/" + endpoint,
        type: 'GET',
        data: params,
        headers: {
            Authorization: "Bearer " + authToken
        },
        dataType: 'json',
        success: function (data) {
            // Hide the spinner
            if (--loadingCount <= 0)
                $('.lds-ripple-wrapper').hide();
            // Call the success callback
            successCallback(data);
        },
        error: function (e) {
            if (--loadingCount <= 0)
                $('.lds-ripple-wrapper').hide();
            console.error(e);
            if (errorCallback)
                errorCallback(e);
            else
                //alert("Something goes wrong!.. please try again later.")
                showAlert('danger', 'SomethingGoesWrong');

        },
    });
}

function jqAjaxPost(endpoint, data, successCallback, errorCallback) {
    $('.lds-ripple-wrapper').show();
    loadingCount++;

    var authToken = getQueryParam('authToken');
    $.ajax({
        url: window.location.origin + (isProduction ? "/SBCCase" : "") + "/api/" + endpoint,
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(data),
        headers: {
            Authorization: "Bearer " + authToken
        },
        dataType: 'json',
        success: function (data) {
            // Hide the spinner
            if (--loadingCount <= 0)
                $('.lds-ripple-wrapper').hide();
            // Call the success callback
            successCallback(data);
        },
        error: function (e) {
            if (--loadingCount <= 0)
                $('.lds-ripple-wrapper').hide();
            console.error(e);
            if (errorCallback)
                errorCallback(e);
            else
                //alert("Something goes wrong!.. please try again later.")
                showAlert('danger', 'SomethingGoesWrong');

        },
    });

}

function setLangDirectionOnLoad() {

    const lang = getQueryParam('lang') || 'en';

    // Set the direction and language attributes
    if (lang == 'ar') {
        document.documentElement.setAttribute('dir', 'rtl');
        document.documentElement.setAttribute('lang', 'ar');
        document.body.setAttribute('dir', 'rtl');
        document.body.setAttribute('lang', 'ar');
    } else {
        document.documentElement.setAttribute('dir', 'ltr');
        document.documentElement.setAttribute('lang', 'en');
        document.body.setAttribute('dir', 'ltr');
        document.body.setAttribute('lang', 'en');
    }
}
function switchLanguage(lang) {
    var searchParams = new URLSearchParams(window.location.search);
    searchParams.set('lang', lang);
    var newUrl = window.location.pathname + '?' + searchParams.toString();
    window.location.href = newUrl;
}


function checkVisibility() {
    $('.fade-in').each(function () {
        var elementTop = $(this).offset().top;
        var elementBottom = elementTop + $(this).outerHeight();
        var viewportTop = $(window).scrollTop();
        var viewportBottom = viewportTop + $(window).height();

        if (elementBottom > viewportTop && elementTop < viewportBottom) {
            $(this).addClass('show');
        }
    });
}

function getQueryParam(param) {
    var urlParams = new URLSearchParams(window.location.search);
    return urlParams.get(param);
}

function ShowQuickMessage(elementId, message, color) {
    $(elementId)
        .text(message)
        .css({
            "text-shadow": "0px 0px 5px " + color,
            "opacity": 1
        })
        .fadeIn('slow')
        .delay(6000)
        .fadeTo('slow', 0.01, function () {
            $(this).css("text-shadow", "none");
        });
}




function showAlert(messageType, messageKey, customTemplateId) {
    // Get the alert template

    var alertTemplate = document.getElementById(customTemplateId ?? 'alertTemplate');

    // Set the appropriate alert class based on the message type
    alertTemplate.classList.remove('alert-info', 'alert-success', 'alert-danger', 'alert-warning');

    switch (messageType) {
        case 'success':
            alertTemplate.classList.add('alert-success');
            break;
        case 'danger':
            alertTemplate.classList.add('alert-danger');
            break;
        case 'warning':
            alertTemplate.classList.add('alert-warning');
            break;
        default:
            alertTemplate.classList.add('alert-info');
    }

    var msg = translatedMessages.find(x => x.Key == messageKey);
    if (!msg) {
        console.error("Can't find translated message Key");
        return;
    }

    // Set the alert message
    $('#' + (customTemplateId ?? 'alertTemplate') + ' > span.alertMessage').text(msg.Content);

    // Display the alert smoothly
    alertTemplate.style.display = 'block';
    setTimeout(function () {
        alertTemplate.style.opacity = 1;
    }, 10);
}

function hideAlert() {
    // Hide the alert template
    var alertTemplates = $('.alertTemplate');

    if (!alertTemplates || alertTemplates.length == 0) {
        console.error("alertTemplates is null or empty, cant hide alert", alertTemplates);
        return;
    }


    $(alertTemplates).attr('style', 'opacity : 0');
    setTimeout(function () {
        $(alertTemplates).attr('style', 'display : none');
    }, 500);
}