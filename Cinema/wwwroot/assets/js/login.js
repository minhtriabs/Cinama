
function Validator(options) {
    var isFormValid = true;
    var selectorRules = {};
    function validate(inputEmlement, rule) {
        var errorElement = inputEmlement.parentElement.querySelector(options.errorSelector);
        var rules = selectorRules[rule.selector];
        for (var i = 0; i < rules.length; ++i) {
            errorMessage = rules[i](inputEmlement.value);
            if (errorMessage) break;
        }
        if (errorMessage) {
            errorElement.innerText = errorMessage;
            inputEmlement.parentElement.classList.add('invalid');
        }
        else {
            errorElement.innerText = '';
            inputEmlement.parentElement.classList.remove('invalid');
        }
        return !errorMessage;
    }
    var formElement = document.querySelector(options.form);
    if (formElement) {
        formElement.onsubmit = function (e) {
            options.rules.forEach(function (rule) {
                var inputEmlement = formElement.querySelector(rule.selector);
                var isValid = validate(inputEmlement, rule);
                if (isValid == false) {
                    isFormValid = false;
                }
            });
            var flag = true;
            var arrErrorMessage = document.querySelectorAll(options.errorSelector);
            for (let i = 0; i < arrErrorMessage.length; i++) {
                if (arrErrorMessage[i].textContent !== '') {
                    flag = false;
                    break;
                }
            }
            if (flag) {
                if (typeof options.onSubmit === 'function') {
                    var enableInputs = formElement.querySelectorAll('[name]:not([disabled])');
                    var formValues = Array.from(enableInputs).reduce(function (values, input) {
                        return (values[input.name] = input.value) && values;
                    }, {});
                    options.onSubmit(formValues);
                }
            }


        };

        options.rules.forEach(function (rule) {

            if (Array.isArray(selectorRules[rule.selector])) {
                selectorRules[rule.selector].push(rule.test);
            } else {
                selectorRules[rule.selector] = [rule.test];
            }

            var inputEmlement = formElement.querySelector(rule.selector);

            if (inputEmlement) {
                inputEmlement.onblur = function () {
                    validate(inputEmlement, rule);

                }
                inputEmlement.oninput = function () {
                    var errorElement = inputEmlement.parentElement.querySelector(options.errorSelector);
                    errorElement.innerText = '';
                    inputEmlement.parentElement.classList.remove('invalid');
                }
            }
        });
    }

}
Validator.isUsername = function (selecter) {
    return {
        selector: selecter,
        test: function (value) {
            return value.trim() ? undefined : 'Vui lòng nhập tài khoản.';
        }
    };
};
Validator.isPassword = function (selecter, min) {
    return {
        selector: selecter,
        test: function (value) {
            return value.length >= min ? undefined : `Vui lòng nhập tối thiểu ${min} kí tự`;
        }
    };
};