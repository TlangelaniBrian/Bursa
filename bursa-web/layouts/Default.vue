<template>
  <div class="default-layout">
    <Header />
    <div class="main-container">
      <main class="main">
        <NuxtLoadingIndicator />
        <slot></slot>
      </main>
    </div>
    <Footer />
  </div>
</template>

<script setup lang="ts"></script>

<style scoped lang="scss">
.default-layout {
  display: flex;
  flex-direction: column;
  height: 100vh;
  width: 100vw;
  background-color: var(--color-lighter-grey);
  color: var(--text-color);
}
.main-container {
  margin: var(--main-margin-top) var(--main-margin-right) 0 var(--main-margin-left);
  padding: 0px;
  height: calc(100vh - 100px);
  width: 100vw;
  .main {
    padding: 16px;
    margin: 0px 50px 0px 50px;
  }
}
</style>
