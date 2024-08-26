import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ABPOnlineStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44393/',
    redirectUri: baseUrl,
    clientId: 'ABPOnlineStore_App',
    responseType: 'code',
    scope: 'offline_access ABPOnlineStore',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44393',
      rootNamespace: 'ABPOnlineStore',
    },
  },
} as Environment;
