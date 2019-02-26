        // 'off' or 0 - turn the rule off
// 'warn' or 1 - turn the rule on as a warning (doesn’t affect exit code)
// 'error' or 2 - turn the rule on as an error (exit code is 1 when triggered)
// For more detailed information see: http://eslint.org/docs/user-guide/configuring
module.exports = {
    'parser': 'babel-eslint',
    'parserOptions': {
        'sourceType': 'module'
    },
    // Specifying environments:
    // An environment defines global variables that are predefined.
    'env': {
        'browser': true, // Browser global variables
        'es6': true, // Enable all ECMAScript 6 features except for modules (this automatically sets the ecmaVersion parser option to 6)
    },
    'globals': {
        'process': true,
        'require': true,
        'module': true
    },
    'plugins': [
        // This ESLint plugin allows linting and fixing inline scripts contained in HTML files.
        // See: https://www.npmjs.com/package/eslint-plugin-html
        'html'
    ],
    // You can override settings from this shareable config by adding them directly into your '.eslintrc' file.
    // See the ESLint documentation http://eslint.org/docs/developer-guide/shareable-configs#using-a-shareable-config
    // for more information about using a shareable config.
    'extends': 'crockford',
    // See: https://eslint.org/docs/rules/ {rule name here}
    'rules': {
        'space-before-function-paren': [
            'error',
            {
                'anonymous': 'always',
                'named': 'never',
                'asyncArrow': 'always'
            }
        ],
        'eol-last': 0,
        'one-var': 0,
        'new-cap': 0,
        'indent': [
            'error',
            4,
            {
                'SwitchCase': 1
            }
        ],
        'no-plusplus': 0,
        'no-underscore-dangle': 0,
        'no-unused-vars': [
            'error',
            {
                'args': 'after-used'
            }
        ]
    }
}
