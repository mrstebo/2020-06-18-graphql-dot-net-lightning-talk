import React from 'react';
import { Divider, Header, Image, Segment } from 'semantic-ui-react';
import logo from '../assets/dootrix-logo.png';
import styles from './WelcomePage.module.scss';

export const WelcomePage: React.FC = () => {
  return (
    <div className={styles.container}>
      <Header size="huge" textAlign="center">
        Dootrix Library
        <Header.Subheader>Recommended Reading</Header.Subheader>
      </Header>
      <div className={styles.logoWrapper}>
        <Image className={styles.logo} src={logo} />
      </div>
      <Divider />
      <Segment circular={true} padded={true} size="massive">
        Source code available{' '}
        <a
          href="https://github.com/mrstebo/2020-06-18-graphql-dot-net-lightning-talk"
          target="_blank"
        >
          here
        </a>
      </Segment>
    </div>
  );
};
