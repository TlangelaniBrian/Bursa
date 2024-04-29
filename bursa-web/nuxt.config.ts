// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  ssr: true,
  routeRules: {
    "/login": { ssr: false }
  },
  imports: {
    dirs: ["stores"]
  },
  devtools: {
    enabled: true,
    timeline: {
      enabled: true,
    },
  },
  alias: {
    assets: "/<rootDir>/assets",
  },
  app: {
    head: {
      script: [
        {
          type: "module",
          src: "https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.esm.js"
        },
        {
          type: "nomodule",
          src: "https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.js"
        }
      ],
      link: [
        { rel: 'icon', type: 'image/png', href: '/icon.png' }
      ]
    }
  },
  modules: ["@pinia/nuxt", "@nuxt/image", "nuxt-primevue", "@vueuse/nuxt"],
  css: ["primeflex/primeflex.css"],
  primevue: {
    options: {
      unstyled: false,
    },
    components: {
      prefix: "Prime",
    }
  },
  nitro: {
    compressPublicAssets: true,
  },
  vite: {
    vue: {
      template: {
        compilerOptions: {
          isCustomElement: (tag) => tag.startsWith("omni-"),
        },
      },
    },
  },
})