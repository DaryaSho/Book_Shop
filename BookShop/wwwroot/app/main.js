import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './App.vue';
//import Layout from './components/Layout/Header.vue';
import Layout from './Layout/Header.vue';
import VueCroppie from 'vue-croppie';

import BootstrapVue from 'bootstrap-vue';

import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';
//import './styles/main.css';

Vue.config.productionTip = false;
Vue.use(VueRouter);
Vue.use(BootstrapVue);
Vue.use(VueCroppie);

const routes = [
    {
        path: '/',
        component: App
    }
];

const router = new VueRouter({
    routes,
    mode: 'history'
});

new Vue({
    el: '#app',
    template: "<div><layout></layout></div>",
    components: {
        'layout': Layout
    },
    router
})