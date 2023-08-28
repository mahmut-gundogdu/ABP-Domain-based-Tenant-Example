import { Environment } from '@abp/ng.core';

const baseUrl = 'http://multitenancydemo.local:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'MultiTenancyDemo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'http://multitenancydemo.local:44394/',
    redirectUri: baseUrl,
    clientId: 'MultiTenancyDemo_App',
    responseType: 'code',
    scope: 'offline_access MultiTenancyDemo',
    requireHttps: false,
  },
  apis: {
    default: {
      url: 'http://multitenancydemo.local:44394',
      rootNamespace: 'MultiTenancyDemo',
    },
  },
} as Environment;
