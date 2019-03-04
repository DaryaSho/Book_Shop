import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './App.vue';
//import Layout from './components/Layout/Header.vue';
import Layout from './Layout/Header.vue';
import VueCroppie from 'vue-croppie';
import Publisher from './components/publisher.vue';

import BootstrapVue from 'bootstrap-vue';

import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';

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
    //template: "<div><layout></layout></div>",
    template: "<div><publisher></publisher></div>",
    components: {
        'layout': Layout,
        'publisher': Publisher
    },
    router
})