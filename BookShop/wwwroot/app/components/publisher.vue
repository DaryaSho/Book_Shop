<template>
    <div class="info">
        <b>Жанры</b><br>
        <span > {{title}}  {{info}}  </span><br>
      </div>
</template>

<script>
import storeManager from '../../api/storeManager.js';


export default {
    data() {
        return {
            title: null,
            info: null,
        };
    },
    methods:{
        async info() {
            let saved = await storeManager.info({original:this.original});
            this.title = saved.title;
            this.info= saved.info;
        }
    },
    mounted() {
        this.info();
    }

};
</script>

<style>
</style>
