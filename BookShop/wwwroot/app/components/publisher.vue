<template>
    <div class="info">
        Жанры
        <select v-model="selected">
        <option v-for="entry in list" :key="entry.id" >{{entry.title}}</option>
        </select>
        <span>{{info}}</span>
    </div>
</template>

<script>
import storeManager from '../../api/storeManager.js';


export default {
    data() {
        return {
            list: null,
            title: null,
            info: null,
            selected:''
        };
    },
    methods:{
        async inform() {
            this.list = await storeManager.information();
        }
    },
    mounted() {
        this.inform();
    }
};
</script>

<style>
</style>
