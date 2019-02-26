const webpack = require('webpack'),
    { VueLoaderPlugin } = require('vue-loader'),
    path = require('path'),
    rootPath = '../../wwwroot',
    sourceDir = rootPath + '/app',
    bundleOutputDir = rootPath + '/dist';

module.exports = {
    mode: 'development',
    context: __dirname,
    entry: {
        app: ['babel-polyfill', sourceDir + '/main.js']
    },
    //entry: {
    //    app: sourceDir + '/main.js'
    //},
    output: {
        path: path.join(__dirname, bundleOutputDir),
        filename: '[name].js',
        publicPath: '/dist/'
    },
    module: {
        rules: [
            {
                test: /\.css$/,
                use: [
                    'vue-style-loader',
                    'css-loader'
                ],
            },
            {
                test: /\.vue$/,
                loader: 'vue-loader',
                options: {
                    loaders: {
                        'scss': [
                            'vue-style-loader',
                            'css-loader',
                            'sass-loader'
                        ],
                        'sass': [
                            'vue-style-loader',
                            'css-loader',
                            'sass-loader?indentedSyntax'
                        ]
                    }
                }
            },
            {
                test: /\.js$/,
                loader: 'babel-loader',
                exclude: /node_modules/
            },
            {
                test: /\.(js|vue)$/,
                loader: 'eslint-loader',
                enforce: 'pre',
                include: [path.join(__dirname, sourceDir)],
                options: {
                    formatter: require('eslint-friendly-formatter')
                },
            },
            {
                test: /\.(png|jpg|gif|svg)$/,
                loader: 'file-loader',
                options: {
                    name: '[name].[ext]?[hash]'
                }
            }
        ]
    },
    resolve: {
        alias: {
            'vue$': 'vue/dist/vue.esm.js',
            '@': path.join(__dirname, sourceDir)
        },
        extensions: ['.js', '.vue', '.json']
    },
    devServer: {
        historyApiFallback: true,
        noInfo: true,
        overlay: true
    },
    performance: {
        hints: false
    },
    devtool: '#cheap-module-eval-source-map',
    plugins: [
        new VueLoaderPlugin()
    ]
}
