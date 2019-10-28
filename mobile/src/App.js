import React from 'react';
import {SafeAreaView, StyleSheet} from 'react-native';

import Header from './components/Header';
import List from './components/List';
import ButtonFloat from './components/ButtonFloat';
import Modal from './components/Modal';

export default App = () => {
  return (
    <SafeAreaView style={styles.container}>
      <Header />
      <List style={styles.list} />
      <ButtonFloat />
      <Modal />
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  container: {
    marginBottom: 100,
  },
});
