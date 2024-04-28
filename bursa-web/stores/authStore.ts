import { defineStore } from 'pinia';
export const useAuthStore = defineStore('auth', () => {

    const isAuthenticated = ref(true);
    const userRole = ref("admin");

    const isAdmin = computed(() => isAuthenticated.value && userRole.value === "admin");

    const login = () => {
        isAuthenticated.value = true;
    };
    const logout = () => {
        isAuthenticated.value = false;
    };
    return {
        isAuthenticated,
        userRole,
        isAdmin,
        login,
        logout
    };
});