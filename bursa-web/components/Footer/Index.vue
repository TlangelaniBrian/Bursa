<template>
  <div class="footer-index-container">
    <footer class="footer">
      <div class="footer-holder">
        <div class="spacer">
          <div class="margin-left">
            <p>&copy; {{ new Date().getFullYear() }}</p>
          </div>
        </div>
      </div>
    </footer>
  </div>
</template>

<script setup lang="ts"></script>

<style scoped lang="scss">
.footer {
  position: fixed;
  bottom: 0px;
  width: 100vw;
  background-color: var(--color-light-grey);
  padding: 12px 0px 12px 0px;

  .footer-holder {
    display: flex;
    justify-content: flex-end;

    .spacer {
      display: flex;
      flex: 1;

      .margin-left {
        margin-left: 20px;
      }
    }
  }
}
</style>
