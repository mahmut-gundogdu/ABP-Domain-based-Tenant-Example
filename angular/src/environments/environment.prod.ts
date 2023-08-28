import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'MultiTenancyDemo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44394/',
    redirectUri: baseUrl,
    clientId: 'MultiTenancyDemo_App',
    responseType: 'code',
    scope: 'offline_access MultiTenancyDemo',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44394',
      rootNamespace: 'MultiTenancyDemo',
    },
  },
} as Environment;
