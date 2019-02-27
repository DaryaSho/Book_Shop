<template>
	<div class="header">
		<main-menu></main-menu>
	</div>
</template>

<script>
	import MainMenu from './Menu.vue';

	export default {
		components:{
			MainMenu
		}
	};
</script>

<style>
	.header {
		display: flex;
		flex-direction: row;
		width: 100%;
		height: 50px;
		border: solid 1px gray;
		justify-content: space-between;
	}
</style>


