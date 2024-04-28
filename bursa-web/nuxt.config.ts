// https://nuxt.com/docs/api/configuration/nuxt-config
import { resolve } from "path";
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