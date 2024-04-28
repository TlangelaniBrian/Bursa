<template>
  <div>
    <omni-search-field label="Search" value="" clearable>
      <svg
        slot="clear"
        xmlns="http://www.w3.org/2000/svg"
        viewBox="0 0 24 24"
        width="24px"
        height="24px"
        style="fill: orange"
      >
        <path
          d="M12 2.25c5.385 0 9.75 4.365 9.75 9.75s-4.365 9.75-9.75 9.75S2.25 17.385 2.25 12 6.615 2.25 12 2.25Zm0 1.5a8.25 8.25 0 1 0 0 16.5 8.25 8.25 0 0 0 0-16.5ZM8.47 8.47a.75.75 0 0 1 1.06 0L12 10.939l2.47-2.47a.75.75 0 0 1 .976-.072l.084.073a.75.75 0 0 1 0 1.06L13.061 12l2.47 2.47a.75.75 0 0 1 .072.976l-.073.084a.75.75 0 0 1-1.06 0L12 13.061l-2.47 2.47a.75.75 0 0 1-.976.072l-.084-.073a.75.75 0 0 1 0-1.06L10.939 12l-2.47-2.47a.75.75 0 0 1-.072-.976Z"
        ></path>
      </svg>
    </omni-search-field>
    <div v-for="item in items" :key="item.id">
      <span>
        <i>{{ item.name }}</i>
      </span>
    </div>
  </div>
</template>

<script setup lang="ts">
import "@capitec/omni-components/search-field";
const items = [
  {
    name: "Item 1",
    id: 1,
  },
  {
    name: "Item 2",
    id: 2,
  },
  {
    name: "Item 3",
    id: 3,
  },
];
</script>

<style scoped></style>
