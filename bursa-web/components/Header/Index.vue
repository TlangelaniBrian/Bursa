<template>
  <div>
    <header>
      <nav>
        <omni-expander-group expand-mode="multiple">
          <omni-expander label="User">
            <ul>
              <li>
                <NuxtLink to="/">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Home</span>
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/profile">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Profile</span>
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/admin"
                  ><span class="nav-icon">xxx</span>
                  <span class="nav-title">Admin</span>
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/login">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Login</span>
                </NuxtLink>
              </li>
            </ul>
          </omni-expander>
          <omni-expander label="Student">
            <ul>
              <li>
                <NuxtLink to="/transactions">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Transactions</span>
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/pocket">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Pocket</span>
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/balances">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Balances</span>
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/residence">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Residence</span>
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/paymentHistory">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Payment History</span>
                </NuxtLink>
              </li>
            </ul>
          </omni-expander>
          <omni-expander label="Back Office">
            <ul>
              <li>
                <NuxtLink to="/settings">
                  <span class="nav-icon">xxx</span>
                  <span class="nav-title">Settings</span></NuxtLink
                >
              </li>
            </ul>
          </omni-expander>
        </omni-expander-group>
      </nav>
    </header>
  </div>
</template>

<script setup lang="ts">
import "@capitec/omni-components/expander";
</script>

<style scoped></style>
